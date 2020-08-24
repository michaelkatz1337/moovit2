using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = api.GetPassangersAmnt(1);
        }

        protected void Add_btn_Click(object sender, EventArgs e)
        {
            api.AddPassanger(1);
            Response.Redirect(Request.RawUrl);
        }

        protected void Remove_btn_Click(object sender, EventArgs e)
        {
            api.RemovePassanger(1);
            Response.Redirect(Request.RawUrl);
        }
    }
}