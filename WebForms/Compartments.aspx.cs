using BusinessLogic;
using DomainModel;
using System;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Compartments : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Warehouse _warehouse;
        private Organization _loggedOrganization;
        private int _id;

        public Compartments()
        {
            _appManager = new AppManager();
        }

        private void BindCompartmentsRpt()
        {
            CompartmentsRpt.DataSource = _warehouse.Compartments;
            CompartmentsRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _warehouse.Compartments = _warehouse.Compartments.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void FetchCompartments()
        {
            bool listActive = true;
            bool listInactive = true;

            string activityStatusDDL = ActivityStatusDDL.SelectedValue;

            if (activityStatusDDL == "Active")
            {
                listInactive = false;
            }
            else if (activityStatusDDL == "Inactive")
            {
                listActive = false;
            }

            _warehouse.Compartments = _appManager.Compartments.List(_warehouse.Id, listActive, listInactive);
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchCompartments();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindCompartmentsRpt();
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

        protected void ActivityStatusDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTxt.Text = string.Empty;
            MapControls();
        }

        protected void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            MapControls(true);
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            MapControls(true);
        }

        protected void CompartmentsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int compartmentId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditCompartment.aspx?id={compartmentId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Compartments.Toggle(compartmentId);
                MapControls();
            }
        }
    }
}