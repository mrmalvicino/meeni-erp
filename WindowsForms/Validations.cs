using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public static class Validations
    {
        // METHODS

        public static bool isNumber(string input)
        {
            foreach (char c in input)
                if (!(char.IsNumber(c)))
                    return false;

            return true;
        }

        public static void error(string message)
        {
            MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
