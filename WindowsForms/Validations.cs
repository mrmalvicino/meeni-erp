using System.Windows.Forms;

namespace WindowsForms
{
    public static class Validations
    {
        // METHODS

        public static bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!(char.IsNumber(c)))
                {
                    return false;
                }
            }

            return true;
        }

        public static void error(string message)
        {
            MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool hasData(string text)
        {
            if (text == null)
            {
                return false;
            }

            if (text == "")
            {
                return false;
            }

            if (text.Length < 2)
            {
                return false;
            }

            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            return true;
        }
    }
}
