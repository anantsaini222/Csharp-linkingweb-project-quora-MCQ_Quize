using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkingWebAssignment
{
    public partial class QnA : System.Web.UI.Page
    {
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string sName = Request.QueryString["uName"].ToString();
            Label1.Text = sName + ", Welcome Back";
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Quize.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}