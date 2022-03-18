using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azur_application
{
    public static class ThemeColor
    {
        public static Color ActiveColor { get; set; }

        public static List<string> ColorList = new List<string>()
        {
            "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800",
            "#9C27B0", "#2196F3", "#EA676C", "#5978BB", "#018790",
            "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E",
            "#F37521", "#126881", "#8BC240", "#CF1B10", "#B71C46",
            "#7851A9", "#0094BC", "#43B76E", "#7BCFE9", "#1BD13F",
            "#DC3545", "#28A745", "#FFC107"
            
            /*
            "#0073E5"
            */
        };
    }
}
