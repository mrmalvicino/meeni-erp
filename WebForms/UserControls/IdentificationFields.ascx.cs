using DomainModel.Base;
using BusinessLogic;
using System;
using Utilities;

namespace WebForms.UserControls
{
    public partial class IdentificationFields : System.Web.UI.UserControl
    {
        private AppManager _appManager;
        private Identification _identification;

        public IdentificationFields()
        {
            _appManager = new AppManager();
        }

        public Identification Identification
        {
            get
            {
                _identification = (Identification)ViewState["Identification"];

                if (_identification == null)
                {
                    _identification = new Identification(true);
                }

                _identification.Code = Formatter.FormatIdentificationCode(IdentificationCodeTxt.Text);

                int id = Convert.ToInt32(IdentificationTypesDDL.SelectedValue);
                _identification.IdentificationType = _appManager.IdentificationTypes.Read(id);

                return _identification;
            }

            set
            {
                _identification = value;

                if (_identification != null)
                {
                    IdentificationCodeTxt.Text = _identification.Code;
                    IdentificationTypesDDL.SelectedValue = _identification.IdentificationType.Id.ToString();
                    ViewState["Identification"] = _identification;
                }
            }
        }

        public void BindIdentificationTypesDDL()
        {
            IdentificationTypesDDL.DataSource = _appManager.IdentificationTypes.List();
            IdentificationTypesDDL.DataTextField = "Name";
            IdentificationTypesDDL.DataValueField = "Id";
            IdentificationTypesDDL.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindIdentificationTypesDDL();
            }
        }
    }
}