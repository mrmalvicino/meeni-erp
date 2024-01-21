using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsForms
{
    public static class Palette
    {
        // METHODS

        public static Color darkBackground()
        {
            return Color.FromArgb(30, 100, 140);
        }

        public static Color lightBackground()
        {
            return Color.FromArgb(215, 230, 240);
        }

        public static Color font()
        {
            return Color.FromArgb(0, 70, 100);
        }
    }
}
