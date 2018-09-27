using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLogin
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uname"] != null)
            {
                Master.Li.Visible = false;
                Master.Lo.Visible = true;
                if (Session["UType"] != null && Session["UType"].ToString() == "Administrator")
                {
                    Master.Aut.Visible = true;
                }
            }
            else
            {
                Response.Redirect("~/Master.aspx");
            }
        }
    }
}