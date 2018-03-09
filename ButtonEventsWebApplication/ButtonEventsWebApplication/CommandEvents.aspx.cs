using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ButtonEventsWebApplication
{
    public partial class CommandEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":  Label1.Text = "Print Button Clicked";
                break;

                case "Delete": Label1.Text = "Delete Button Clicked";
                break;

                case "Show":
                    if(e.CommandArgument.ToString()=="Top10")
                        Label1.Text="Top 10 Button clicked";
                    else
                     Label1.Text = "Bottom 10 Button clicked";
                break;
                 
                    

            }
        }
    }
}