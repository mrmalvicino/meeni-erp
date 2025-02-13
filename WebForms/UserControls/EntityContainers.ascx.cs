using DomainModel.Base;
using System;

namespace WebForms.UserControls
{
    public partial class EntityContainers : System.Web.UI.UserControl
    {
        private Entity _entity;

        public Entity Entity
        {
            get { return _entity; }
            set { _entity = value; }
        }

        public bool IsOrganizationVisibility
        {
            get { return IsOrganizationDiv.Visible; }
            set { IsOrganizationDiv.Visible = value; }
        }

        private void MapNameAttribute()
        {
            if (IsOrganizationChk.Checked)
            {
                _entity.OrganizationName = EntityNameFieldsUC.OrganizationName;
            }
            else
            {
                _entity.FirstName = EntityNameFieldsUC.FirstName;
                _entity.LastName = EntityNameFieldsUC.LastName;
            }
        }

        public void MapAttributes()
        {
            _entity.Image = ImageContainerUC.Image;
            MapNameAttribute();
            _entity.IsOrganization = IsOrganizationChk.Checked;
            _entity.Identification = IdentificationFieldsUC.Identification;
            _entity.BirthDateString = BirthDateTxt.Text;
            _entity.Email = ContactFieldsUC.Email;
            _entity.Phone = ContactFieldsUC.Phone;
            _entity.Address = AddressContainerUC.Address;
        }

        private void MapNameControls()
        {
            if (_entity.IsOrganization)
            {
                IsOrganizationChk.Checked = true;
                EntityNameFieldsUC.ShowOrganizationName();
                EntityNameFieldsUC.OrganizationName = _entity.OrganizationName;
            }
            else
            {
                IsOrganizationChk.Checked = false;
                EntityNameFieldsUC.ShowPersonName();
                EntityNameFieldsUC.FirstName = _entity.FirstName;
                EntityNameFieldsUC.LastName = _entity.LastName;
            }
        }

        public void MapControls()
        {
            ImageContainerUC.Image = _entity.Image;
            MapNameControls();
            IsOrganizationChk.Checked = _entity.IsOrganization;
            IdentificationFieldsUC.Identification = _entity.Identification;
            BirthDateTxt.Text = _entity.BirthDateString;
            ContactFieldsUC.Email = _entity.Email;
            ContactFieldsUC.Phone = _entity.Phone;
            AddressContainerUC.Address = _entity.Address;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MapControls();
            }
        }

        protected void IsOrganizationChk_CheckedChanged(object sender, EventArgs e)
        {
            EntityNameFieldsUC.ToggleNameType();
        }
    }
}