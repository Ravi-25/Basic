using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageNavigation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Name
        {
            get
            {
                return TxtNm.Text;
            }
        }
        public string Email
        {
            get
            {
                return TxtEmail.Text;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/webform2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webform2.aspx", false);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("http://google.ccom");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Execute("~/Webform2.aspx",false);
            Label1.Text = "Back To WebForm1, Finished Processing Webform1.aspx";
            Label1.ForeColor = System.Drawing.Color.Green;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Server.Execute("http://google.ccom");
        }
    }
}