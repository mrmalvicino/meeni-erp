using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public class FormsManager
    {
        // ATTRIBUTES

        MainForm _mainForm;

        // CONSTRUCT

        public FormsManager(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        // METHODS

        public void loadForm<FormClass>() where FormClass : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormClass formClass)
                {
                    if (formClass.WindowState == FormWindowState.Minimized)
                    {
                        formClass.WindowState = FormWindowState.Normal;
                    }

                    formClass.BringToFront();
                    return;
                }
            }

            FormClass newForm = new FormClass();
            newForm.MdiParent = _mainForm;
            newForm.Show();
        }

        public void closeForm<FormClass>() where FormClass : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormClass formClass)
                {
                    form.Close();
                    break;
                }
            }
        }
    }
}
