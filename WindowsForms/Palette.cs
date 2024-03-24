using System.Drawing;

namespace WindowsForms
{
    public static class Palette
    {
        // ATTRIBUTES

        public static Color _darkBackColor;
        public static Color _lightBackColor;
        public static Color _foreColor;
        public static Color _validationColor;
        public static Color _defaultWhite;
        public static Color _defaultBlack;

        // PROPERTIES

        public static Color DarkBackColor { get { return  _darkBackColor; } }
        public static Color LightBackColor { get { return _lightBackColor; } }
        public static Color ForeColor { get { return _foreColor; } }
        public static Color ValidationColor { get { return _validationColor; } }
        public static Color DefaultWhite { get { return _defaultWhite; } }
        public static Color DefaultBlack { get { return _defaultBlack; } }

        // METHODS

        public static void setDefaultSkin()
        {
            _darkBackColor = Color.FromArgb(30, 100, 140);
            _lightBackColor = Color.FromArgb(215, 230, 240);
            _foreColor = Color.FromArgb(0, 70, 100);
            _validationColor = Color.FromArgb(255, 0, 0);
            _defaultWhite = SystemColors.Window;
            _defaultBlack = SystemColors.WindowText;
        }

        public static void setDarkSkin()
        {
            _darkBackColor = Color.FromArgb(0, 0, 0);
            _lightBackColor = Color.FromArgb(0, 0, 100);
            _foreColor = Color.FromArgb(140, 180, 230);
            _validationColor = Color.FromArgb(255, 0, 0);
            _defaultWhite = SystemColors.Window;
            _defaultBlack = SystemColors.WindowText;
        }

        public static void setLightSkin()
        {
            _darkBackColor = Color.FromArgb(225, 225, 235);
            _lightBackColor = Color.FromArgb(240, 240, 240);
            _foreColor = Color.FromArgb(80, 80, 80);
            _validationColor = Color.FromArgb(255, 0, 0);
            _defaultWhite = SystemColors.Window;
            _defaultBlack = SystemColors.WindowText;
        }
    }
}
