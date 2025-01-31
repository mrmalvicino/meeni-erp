using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web.UI.HtmlControls;

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

        private void FetchLoggedOrganization()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
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

        private void MapControls(bool applyFilter = false)
        {
            FetchPartners();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindPartnersRpt();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();
            
            FetchLoggedOrganization();

            if (!IsPostBack)
            {
                MapControls();
            }
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
                Label partnerTypeLbl = (Label)e.Item.FindControl("PartnerTypeLbl");

                if (partner.IsClient && partner.IsSupplier)
                {
                    partnerTypeLbl.Text = "<i class='bi bi-people text-success'></i>";
                    partnerTypeLbl.ToolTip = "Cliente y proveedor";
                }
                else if (partner.IsClient)
                {
                    partnerTypeLbl.Text = "<i class='bi bi-cart text-primary'></i>";
                    partnerTypeLbl.ToolTip = "Cliente";
                }
                else if (partner.IsSupplier)
                {
                    partnerTypeLbl.Text = "<i class='bi bi-truck text-warning'></i>";
                    partnerTypeLbl.ToolTip = "Proveedor";
                }
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
    }
}