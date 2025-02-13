using DomainModel.Organizations;
using DomainModel.Inventory;
using BusinessLogic;
using Exceptions;
using System;

namespace WebForms
{
    public partial class EditWarehouse : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Warehouse _warehouse;
        private Organization _loggedOrganization;
        private int _id;

        public EditWarehouse()
        {
            _appManager = new AppManager();
        }

        private void MapAttributes()
        {
            _warehouse.Name = NameTxt.Text;
            _warehouse.Address = AddressContainerUC.Address;
        }

        private void MapControls(bool applyFilter = false)
        {
            NameTxt.Text = _warehouse.Name;
            AddressContainerUC.Address = _warehouse.Address;
        }

        private void FetchWarehouse()
        {
            int internalId = _appManager.Warehouses.FindOrganizationId(_id);

            if (internalId == _loggedOrganization.Id)
            {
                _warehouse = _appManager.Warehouses.Read(_id);
            }
            else
            {
                Response.Redirect("~/Login.aspx", true);
            }
        }

        private void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        public void FetchURL()
        {
            string id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                _id = Convert.ToInt32(id);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchURL();
            FetchSession();
            FetchWarehouse();

            if (!IsPostBack)
            {
                MapControls();
            }
        }

        protected void CompartmentsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Compartments.aspx?id={_id}");
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                _appManager.Warehouses.Update(_warehouse);
                Response.Redirect("Dashboard.aspx", false);
            }
            catch (ValidationException ex)
            {
                (this.Master.Master as Site)?.ShowModal(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}