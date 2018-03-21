using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControls
{
    public partial class CustomValidator1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LblStatus.Text = "Data Saved";
                LblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LblStatus.Text = "Validation Error! Data Not Saved";
                LblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void CustomValidatorEvenNumber_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                int Number;
                bool isNumber = int.TryParse(args.Value, out Number);
                if (isNumber && Number >= 0 && (Number % 2) == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}