using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLogin
{
    public partial class Sucess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uname"] != null)
            {
                Lbl.Text = "You Have Sucessfully registered with User Name : <i>" + Session["Uname"].ToString() + "</i>" + "<br/>" + "Please Click the Link to Login ";
            }
        }
    }
}