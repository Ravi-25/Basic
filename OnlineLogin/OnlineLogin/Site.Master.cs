using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLogin
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        public LinkButton Li
        {
            get { return this.TxtLi; }
        }
        public LinkButton Lo
        {
            get { return this.TxtLo; }
        }
        public LinkButton Aut
        {
            get { return this.TxtAud; }
        }
        public void Btn_Link_Click(object sender, EventArgs e)
        {
            Session["Uname"] = null;
            //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "disableBackButton()", true);
            //Response.Redirect("~/Master.aspx");
            Server.Transfer("~/Master.aspx");
        }
        public void BtnAud_Link_Click(object sender, EventArgs e)
        {
            if (Session["Uname"] != null && Session["UType"].ToString() == "Administrator")
            {
                Response.Redirect("~/Authorisation.aspx");
            }
            else if (Session["Uname"] != null && Session["UType"].ToString() != "Administrator")
            {
                Response.Redirect("~/NotAut.aspx");
            }
        }
    }
}