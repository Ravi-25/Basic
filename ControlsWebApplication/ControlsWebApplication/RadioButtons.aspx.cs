using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsWebApplication
{
    public partial class RadioButtons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
                Response.Write("RED Selected <br>");
            else if (RadioButton2.Checked)
                Response.Write("Yellow Selected <br>");
            else if (RadioButton3.Checked)
                Response.Write("Green Selected <br>");
            else if (RadioButton4.Checked)
                Response.Write("Blue Selected <br>");
            if (RadioButton5.Checked)
                Response.Write("MALE <br>");
            else if (RadioButton6.Checked)
                Response.Write("FEMALE <br>");
        }
    }
}