using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class View_State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["Firstname"] = TextBox1.Text;
            ViewState["Lastname"] = TextBox2.Text;


            TextBox1.Text = TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["Firstname"].ToString();
            TextBox2.Text = ViewState["Lastname"].ToString();
        }
    }
}
