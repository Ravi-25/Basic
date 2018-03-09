using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsWebApplication
{
    public partial class CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
                Response.Write("Gradute");
            if (CheckBox2.Checked)
                Response.Write(" , Post Gradute");
            if (CheckBox3.Checked)
                Response.Write(" , Doctorate");
        }
    }
}