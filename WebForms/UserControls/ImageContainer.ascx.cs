using DomainModel;
using Utilities;
using System;

namespace WebForms.UserControls
{
    public partial class ImageContainer : System.Web.UI.UserControl
    {
        private Image _image;

        public Image Image
        {
            get
            {
                _image = (Image)ViewState["Image"];

                if (_image == null)
                {
                    _image = new Image();
                }

                _image.URL = URLTxt.Text;

                return _image;
            }

            set
            {
                _image = value;

                if (_image != null)
                {
                    URLTxt.Text = _image.URL;
                    ViewState["Image"] = _image;
                }
            }
        }

        public void LoadImage()
        {
            if (Validator.URLExists(URLTxt.Text))
            {
                PictureImg.ImageUrl = URLTxt.Text;
                return;
            }

            URLTxt.Text = "";
            PictureImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}