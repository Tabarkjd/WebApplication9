using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class Hidden_Field : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (HiddenField1.Value == string.Empty)

                HiddenField1.Value = "0";

            HiddenField1.Value = (Convert.ToInt32(HiddenField1.Value) + 1).ToString();
            Label1.Text = HiddenField1.Value;
        }
    }
}