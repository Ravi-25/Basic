using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PanelDynamic
{
    public partial class PanelDynamic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(TextBox1.Text.ToString());
            foreach(ListItem Li in CheckBoxList1.Items)
            {
                if(Li.Selected)
                {
                    if(Li.Text=="TextBox")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Label3.Text = "Text Box Controls";
                            TextBox txtbx = new TextBox();
                            txtbx.Text = "txt-" + i.ToString();
                            //PnlTxt.Controls.Add(txtbx);
                            //this.form1.Controls.Add(txtbx);
                            Td1.Controls.Add(txtbx);
                        }
                    }
                    if (Li.Text == "Button")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Label4.Text = "Buttons Controls";
                            Button Btn = new Button();
                            Btn.Text = "Btn-" + i.ToString();
                            //pnlBtn.Controls.Add(Btn);
                            Td2.Controls.Add(Btn);
                        }
                    }
                    if (Li.Text == "Label")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Label5.Text = "Label Controls";
                            Label Lbl = new Label();
                            Lbl.Text = "Lbl-" + i.ToString();
                            pnlLbl.Controls.Add(Lbl);
                            //this.Page.Controls.Add(Lbl);
                            Td3.Controls.Add(Lbl);
                        }
                    }
                }
            }
        }
    }
}