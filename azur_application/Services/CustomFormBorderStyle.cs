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
        MinMaxButton _MaxButton;

        public CustomFormBorderStyle(Form form, MinMaxButton maxButton, ButtonZ minButton, ButtonZ closeButton)
        {
            this.form = form;

            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "TopPanel")
                {
                    TopPanel = ctrl;
                }
            }
            _MaxButton = maxButton;
        }

        // ------------------------------------ DEPLACEMENT & RESIZE DE LA FENETRE ------------------------------------
        public void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
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
        public void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }
        public void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
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
                        _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        public void TopPanel_MouseUp(object sender, MouseEventArgs e)
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
                    _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }
        public void TopPanel_MouseDown(object sender, MouseEventArgs e)
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

        public void LeftPanel_MouseMove(object sender, MouseEventArgs e)
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
        public void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }
        public void LeftPanel_MouseDown(object sender, MouseEventArgs e)
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

        public void RightPanel_MouseMove(object sender, MouseEventArgs e)
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
        public void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }
        public void RightPanel_MouseDown(object sender, MouseEventArgs e)
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

        public void BottomPanel_MouseMove(object sender, MouseEventArgs e)
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
        public void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }
        public void BottomPanel_MouseDown(object sender, MouseEventArgs e)
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
        public void _MinButton_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        public void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                form.Location = _normalWindowLocation;
                form.Size = _normalWindowSize;
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
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }
        public void _CloseButton_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
