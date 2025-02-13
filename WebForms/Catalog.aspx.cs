using DomainModel.Organizations;
using DomainModel.Products;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Catalog : System.Web.UI.Page
    {
        private AppManager _appManager;
        private List<Product> _products;
        private Organization _loggedOrganization;

        public Catalog()
        {
            _appManager = new AppManager();
        }

        private void BindProductsRpt()
        {
            ProductsRpt.DataSource = _products;
            ProductsRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _products = _products.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void FetchProducts()
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

            _products = _appManager.Products.List(_loggedOrganization.Id, listActive, listInactive);
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchProducts();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindProductsRpt();
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

        protected void ProductsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int productId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditCatalogItem.aspx?id={productId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Warehouses.Toggle(productId);
                MapControls();
            }
        }

        protected void ProductsRpt_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Product product = (Product)e.Item.DataItem;
                Label typeLbl = (Label)e.Item.FindControl("TypeLbl");

                if (product.IsService)
                {
                    typeLbl.Text = "<i class='bi bi-lightning'></i> Servicio";
                }
                else
                {
                    typeLbl.Text = "<i class='bi bi-box-seam'></i> Producto";
                }
            }
        }
    }
}