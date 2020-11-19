using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Value = TextBox1.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(2);
            Label1.Text = "cookie created";
            TextBox1.Text = "";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] == null)
                TextBox2.Text = "There isnt any Cookies";
            TextBox2.Text = Request.Cookies["username"].Value;
            Label1.Text = "";


            
        }
    }
}