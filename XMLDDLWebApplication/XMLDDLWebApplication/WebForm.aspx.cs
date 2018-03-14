using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace XMLDDLWebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet DS = new DataSet();
                string str = Server.MapPath("Countries.xml");
                DS.ReadXml(str);
                DropDownList1.DataSource = DS;
                DropDownList1.DataTextField = "CountryName";
                DropDownList1.DataValueField = "CountryID";
                DropDownList1.DataBind();
                ListItem Li = new ListItem("Select", "-1");
                DropDownList1.Items.Insert(0, Li);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("INDEX: "+DropDownList1.SelectedIndex+"<br>");
            Response.Write("ITEM:  "+DropDownList1.SelectedItem.ToString()+"<br>");
            Response.Write("VALUE: "+DropDownList1.SelectedValue.ToString()+"<br>");

        }
    }
}