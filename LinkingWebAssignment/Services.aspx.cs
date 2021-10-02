using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace LinkingWebAssignment
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sName = Request.QueryString["uName"].ToString();
            Label2.Text = sName + ", Welcome Back In User DataBase";
        }

        
    }
}