using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Browser.Cookies)
                {
                    Response.Write("Cookies are supported by this Browser");

                    if (Request.QueryString["CheckCookie"] == null)
                    {
                        HttpCookie Cookie = new HttpCookie("Test", "1");
                        Response.Cookies.Add(Cookie);
                        Response.Redirect("WebForm1.aspx?CheckCookie=1");
                        //Response.Write("@2");
                    }
                    else
                    {
                        HttpCookie Cookie1 = Request.Cookies["Test"];
                        if (Cookie1 == null)
                        {
                            Label1.Text = "We have Detected that the Browser Cookies are DISABLED";
                            Label1.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else
                {
                    Label1.Text = "This Browser DOESNOT support Cookies";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("Pageinfo");
            Cookie["Name"] = TxtName.Text;
            Cookie["Email"] = TxtEmail.Text;
            Cookie.Expires = DateTime.Now.AddDays(10);

            Response.Cookies.Add(Cookie);


            Response.Redirect("~/WebForm2.aspx");
        }
    }
}