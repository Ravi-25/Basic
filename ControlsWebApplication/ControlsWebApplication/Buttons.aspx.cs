using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsWebApplication
{
    public partial class Button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Page submitted with Button Click");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("Page submitted with Link Button Click");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Page submitted with Image Button Click");
        }
    }
}