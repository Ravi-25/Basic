using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                string type = FileUpload1.PostedFile.ContentType;
                if (extension.ToLower() == ".doc" || extension.ToLower() == ".docx")
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    
                    if (filesize < (2 * 1024 * 1024))//2097152
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
                        Label1.Text = "File Uploaded";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Label1.Text = "File Exceeds 2MB";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    Label1.Text = "Only Word Document Allowed";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                Label1.Text += "<br>" + type;
            }
            else
            {
                Label1.Text = "No File Selected";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }
}