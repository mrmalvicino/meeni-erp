using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Warehouses : System.Web.UI.Page
    {
        private AppManager _appManager;
        private List<Warehouse> _warehouses;
        private Organization _loggedOrganization;

        public Warehouses()
        {
            _appManager = new AppManager();
        }

        private void BindWarehousesRpt()
        {
            WarehousesRpt.DataSource = _warehouses;
            WarehousesRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _warehouses = _warehouses.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void FetchWarehouses()
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

            _warehouses = _appManager.Warehouses.List(_loggedOrganization.Id, listActive, listInactive);
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchWarehouses();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindWarehousesRpt();
        }

        private void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchSession();

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

        protected void WarehousesRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int warehouseId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Compartments")
            {
                Response.Redirect($"Compartments.aspx?id={warehouseId}");
            }
            else if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditWarehouse.aspx?id={warehouseId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Warehouses.Toggle(warehouseId);
                MapControls();
            }
        }
    }
}