using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ErrorEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet DS = new DataSet();
            DS.ReadXml(Server.MapPath("~/Couries.xml"));

            GridView1.DataSource = DS;
            GridView1.DataBind();
        }
        protected void Page_Error(Object sender,EventArgs e)
        {
            Exception Ex = Server.GetLastError();

            Server.ClearError();

            //Response.Redirect("~/ErrorPage.aspx");
        }

        
    }
}