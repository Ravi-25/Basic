using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LifeCycleEventsWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_PreInit: "+ i + "<br/>");
        }
        protected void Page_Init(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_Init: " + i + "<br/>");
        }
        protected void Page_InitComplete(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_InitComplete: " + i + "<br/>");
        }
        protected void Page_PreLoad(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_PreLoad: " + i + "<br/>");
        }
        protected void Page_LoadComplete(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_LoadComplete: " + i + "<br/>");
        }
        protected void Page_PreRender(Object sender, EventArgs e)
        {
            i++; Response.Write("Page_PreRender: " + i + "<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            i++; Response.Write("Page_PreRenderComplete: " + i + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br>");
        }
        protected void Page_load(object sender, EventArgs e)
        {
            i++; Response.Write("Page_load: " + i + "<br/>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            i++; Response.Write("Button Click: " + i + "<br/>");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            i++; Response.Write("Text Changed: " + i + "<br/>");
        }
    }
}