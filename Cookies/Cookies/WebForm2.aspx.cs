using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie Cookie=Request.Cookies["Test"];

            if (Cookie != null)
            {
                Label1.Text = Cookie["Name"];
                Label2.Text = Cookie["Email"];
            }
        }
    }
}