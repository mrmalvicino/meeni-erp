using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public static class Functions
    {
        // METHODS

        public static void loadImage(PictureBox pictureBox, string imageUrl)
        {
            try
            {
                pictureBox.Load(imageUrl);
            }
            catch (Exception)
            {
                pictureBox.Load(".\\..\\..\\..\\images\\profile.png");
            }
        }
    }
}
