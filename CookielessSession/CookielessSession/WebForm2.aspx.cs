using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookielessSession
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Name"]!=null)
            {
                LblName.Text = Session["Name"].ToString();
            }
            if (Session["Email"] != null)
            {
                LblEmail.Text = Session["Email"].ToString();
            }
        }
    }
}