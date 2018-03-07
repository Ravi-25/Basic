using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LifeCycleEventsWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          i++; Response.Write("Button_Click Event: " + i + "<br>");   
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
          i++; Response.Write("TextChanged Event: " + i + "<br>");
        }
    }
}