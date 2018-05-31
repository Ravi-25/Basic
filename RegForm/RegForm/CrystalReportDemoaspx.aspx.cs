using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.Shared;
using System.IO;

namespace RegForm
{
    public partial class CrystalReportDemoaspx1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source =STKS-033-RAVI; Initial Catalog = sample; Persist Security Info=True;User ID = sa; Password=123abc");
        ReportDocument rprt = new ReportDocument();
        string filepath;
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            rprt.Load(Server.MapPath("~/CrystalReport1.rpt"));
            rprt.FileName = Server.MapPath("~/CrystalReport1.rpt");
            SqlCommand cmd = new SqlCommand("Select * from person", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Person");
            rprt.SetDataSource(ds);
            CrystalReportViewer1.ReportSource = rprt;
            CrystalReportViewer1.DataBind();
            pdfdemo();
        }
        public void pdfdemo()
        {
            Response.Clear();
            filepath = Server.MapPath("~/" + "demo.pdf");
            rprt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
            FileInfo fileinfo = new FileInfo(filepath);
            Response.AddHeader("Content-Disposition", "inline;filename=demo.pdf");
            Response.ContentType = "application/pdf";
            Response.WriteFile(fileinfo.FullName);
            Response.Flush();
        }
    }
}