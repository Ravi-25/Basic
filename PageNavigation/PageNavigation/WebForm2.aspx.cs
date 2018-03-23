using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageNavigation
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Collections.Specialized.NameValueCollection PrvFormColl = Request.Form;
            //Lbl1.Text = PrvFormColl["TxtNm"];
            //Lbl2.Text = PrvFormColl["TxtEmail"];


            /********************  OR  ***************************/

            //Page PrvPg = Page.PreviousPage;
            //if(PrvPg!=null && PrvPg.IsCrossPagePostBack)
            //{
            //    Lbl1.Text = ((TextBox)PrvPg.FindControl("TxtNm")).Text;
            //    Lbl2.Text = ((TextBox)PrvPg.FindControl("TxtEmail")).Text;
            //}
            //else
            //{
            //    Label1.Text = "You Landed on this page using a technique other than cross page post back";
            //}


            /********************  OR  ***************************/

            //WebForm1 PrvPg = (WebForm1)this.PreviousPage;  // Before previous page directive

            // after page directive
            WebForm1 prvPg = this.PreviousPage;
            if (prvPg != null)
            {
                Lbl1.Text = prvPg.Name;
                Lbl2.Text = prvPg.Email;
            }
            Lbl1.Text=Request.QueryString["NameOfUser"];
            Lbl2.Text = Request.QueryString["Email"];
        }
    }
}