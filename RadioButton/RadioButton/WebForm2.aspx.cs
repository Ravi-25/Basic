﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButton
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedIndex!=-1)
            {
                Response.Write("Text: " + RadioButtonList1.SelectedItem.Text + "<br>");
                Response.Write("Value: " + RadioButtonList1.SelectedValue.ToString()+ "<br>");
                Response.Write("Index: " + RadioButtonList1.SelectedIndex + "<br>");
            }
        }
    }
}