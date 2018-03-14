using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMLDDLWebApplication.Web2
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath(".")  +"  <h2>(Current DIR)</h2><br>");
            Response.Write(Server.MapPath("..") +"  <h2>(Parent DIR)</h2><br>");
            Response.Write(Server.MapPath("~") + "  <h2>(Root DIR)</h2><br>");
            //Response.Write(Server.MapPath("../..") + " Parent of Parent DIR<br>");
        } 
    }
}