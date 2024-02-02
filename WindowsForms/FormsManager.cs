using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public class FormsManager
    {
        // ATTRIBUTES

        Form _mdiParent = null;

        // PROPERTIES

        public Form MdiParent { get { return _mdiParent; } set { _mdiParent = value; } }

        // CONSTRUCT

        public FormsManager() { }

        public FormsManager(Form mdiParent)
        {
            _mdiParent = mdiParent;
        }

        // METHODS

        public void loadDialogForm<FormClass>() where FormClass : Form, new()
        {
            FormClass form = new FormClass();
            form.ShowDialog();
        }

        public void loadParentForm<FormClass>() where FormClass : Form, new()
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
            newForm.MdiParent = _mdiParent;
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
