using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CustomWindowsForm;
using MySql.Data.MySqlClient;

namespace azur_application.Services
{
    class CustomFormBorderStyle
    {
        private Form form;
        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        Control TopPanel;
        ToolTip toolTip1;
        Control _MaxButton;

        public List<ToolTip> tTipList;
        
        public CustomFormBorderStyle(Form form, System.ComponentModel.IContainer components)
        {
            this.form = form;
            
            tTipList = components.Components.OfType<ToolTip>().ToList();

            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "toolTip1")
                {
                    /*
                    string s = Tooltip.GetTooltip(ctrl);
                    ctrl.ShowTooltip(s, this);
                    */
                }
            }
                foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "TopPanel")
                {
                    TopPanel = ctrl;
                }

                if (ctrl.Name == "_MaxButton")
                {
                    _MaxButton = ctrl;
                }
            }
        }

        // ------------------------------------ DEPLACEMENT & RESIZE DE LA FENETRE ------------------------------------
        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < form.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (form.Height < 50)
                    {
                        form.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        form.Location = new Point(form.Location.X, form.Location.Y + e.Y);
                        form.Height = form.Height - e.Y;
                    }
                }
            }
        }
        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        public void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                form.Location = newPoint;

                if (form.Location.X > 2 || form.Location.Y > 2)
                {
                    if (form.WindowState == FormWindowState.Maximized)
                    {
                        form.Location = _normalWindowLocation;
                        form.Size = _normalWindowSize;
                        toolTip1.SetToolTip(_MaxButton, "Maximiser");
                        /*
                        _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        */
                        isWindowMaximized = false;
                    }
                }
            }
        }
        /*
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (form.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = form.Size;
                    _normalWindowLocation = form.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    form.Location = new Point(0, 0);
                    form.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(_MaxButton, "Restore Down");
                    _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = form.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = form.Location.X - pointStartPosition.X;
                offset.Y = form.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < form.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (form.Width < 100)
                    {
                        form.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        form.Location = new Point(form.Location.X + e.X, form.Location.Y);
                        form.Width = form.Width - e.X;
                    }
                }
            }
        }
        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (form.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                form.Location = new Point(10, form.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (form.Width < 100)
                {
                    form.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    form.Width = form.Width + e.X;
                }
            }
        }
        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (form.Height < 50)
                {
                    form.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    form.Height = form.Height + e.Y;
                }
            }
        }
        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        // ------------------------------------ BOUTONS MIN, MAX, CLOSE ------------------------------------
        private void _MinButton_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                form.Location = _normalWindowLocation;
                form.Size = _normalWindowSize;
                toolTip1.SetToolTip(_MaxButton, "Maximizer");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = form.Size;
                _normalWindowLocation = form.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                form.Location = new Point(0, 0);
                form.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(_MaxButton, "Restore Down");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }
        private void _CloseButton_Click(object sender, EventArgs e)
        {
            form.Close();
        }
        */
    }
}
