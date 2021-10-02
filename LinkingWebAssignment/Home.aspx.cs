using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkingWebAssignment
{
    public partial class Home : System.Web.UI.Page
    {
        int counter;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ViewState["ctr"] = 0;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Anant" && txtPassword.Text == "1@3")
            {
                Response.Redirect("QnA.aspx?uName=" + txtUsername.Text);
            }
            else
            {
                counter = Int32.Parse(ViewState["ctr"].ToString());
                counter++;
                ViewState["ctr"] = counter;
                Label2.Text = "Sorry ! " + txtUsername.Text + " You are not allowed";
                //Response.Write("Sorry " + txtUsername.Text + " You are not allowed");
                if (counter > 2)
                {
                    btnLogin.Enabled = false;
                    Label2.Text = "Please Contact Administrator";
                   //Response.Write("Please Contact Administrator");
                }
            }
        }

    }
}