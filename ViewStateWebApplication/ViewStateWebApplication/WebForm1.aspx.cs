using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClicksCount++;
            TextBox1.Text = ClicksCount.ToString();
        }
    }
}