using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxList
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Selected Value: " + CheckBoxList1.SelectedValue + " ");
            Response.Write("Selected Index: " + CheckBoxList1.SelectedIndex.ToString() + " ");
            if (CheckBoxList1.SelectedItem != null)
            {
                
                Response.Write("Selected Item: " + CheckBoxList1.SelectedItem.Text+" ");
            }
            Response.Write("<br>---------------------------<br>");
            foreach (ListItem Li in CheckBoxList1.Items)
            {
                
                if (Li.Selected)
                {
                    Response.Write("Text: " + Li.Text.ToString() + " ");
                    Response.Write("Value: " + Li.Value.ToString() + " ");
                    Response.Write("Index: " + CheckBoxList1.Items.IndexOf(Li)+" ");
                    Response.Write("<br>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem Li in CheckBoxList1.Items)
            {
                Li.Selected = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (ListItem Li in CheckBoxList1.Items)
            {
                Li.Selected = false;
            }
        }
    }
}