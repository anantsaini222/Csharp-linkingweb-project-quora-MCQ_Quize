using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkingWebAssignment
{
    public partial class Finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string sScore = Request.QueryString["uScore"].ToString();
            Label1.Text = " You have scored : " + sScore ;
        }
    }
}