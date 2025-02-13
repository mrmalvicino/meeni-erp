using DomainModel.Stakeholders;
using DomainModel.Organizations;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Partners : System.Web.UI.Page
    {
        private AppManager _appManager;
        private List<Partner> _partners;
        private Organization _loggedOrganization;

        public Partners()
        {
            _appManager = new AppManager();
        }

        private void BindPartnersRpt()
        {
            PartnersRpt.DataSource = _partners;
            PartnersRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _partners = _partners.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Email.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Phone.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void FetchPartners()
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

            _partners = _appManager.Partners.List(_loggedOrganization.Id, listActive, listInactive);
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchPartners();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindPartnersRpt();
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

        protected void PartnersRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int partnerId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditPartner.aspx?id={partnerId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Partners.Toggle(partnerId);
                MapControls();
            }
        }

        protected void PartnersRpt_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Partner partner = (Partner)e.Item.DataItem;
                Label typeLbl = (Label)e.Item.FindControl("TypeLbl");

                if (partner.IsClient && partner.IsSupplier)
                {
                    typeLbl.Text = "<i class='bi bi-people text-success'></i> Cli. y prov.";
                }
                else if (partner.IsClient)
                {
                    typeLbl.Text = "<i class='bi bi-cart text-primary'></i> Cliente";
                }
                else if (partner.IsSupplier)
                {
                    typeLbl.Text = "<i class='bi bi-truck text-warning'></i> Proveedor";
                }
            }
        }
    }
}