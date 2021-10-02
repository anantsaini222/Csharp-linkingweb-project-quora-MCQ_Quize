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
    public partial class ContactUS : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        String Result;
        String strDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["msdbConnectionString"].ToString();
            CheckBoxList chk = new CheckBoxList();
            if(!IsPostBack)
            {
                ViewState["CDate"] = null;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            strDate = Calendar1.SelectedDate.ToShortDateString();
            ViewState["CDate"] = strDate;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem.ToString()=="Delhi")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("New Delhi");
                DropDownList2.Items.Add("Gurugram");
                DropDownList2.Items.Add("Noida");
                DropDownList2.Items.Add("Connaught");
            }
            if (DropDownList1.SelectedItem.ToString()== "Maharashtra")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Mumbai");
                DropDownList2.Items.Add("Pune");
                DropDownList2.Items.Add("Nagpur");
                DropDownList2.Items.Add("Aurangabad");
            }
            if (DropDownList1.SelectedItem.ToString()== "Karnataka")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Bengaluru");
                DropDownList2.Items.Add("Mangalore");
                DropDownList2.Items.Add("Mysuru");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            con.Open();
            string strInsert = "insert into QuoraRegister values ('" + txtName.Text + "','" + txtPass.Text + "' , '" +
                   txtEmail.Text + "', '" + RadioButtonList1.Text + "' , '" + strDate + "', '" +
                  DropDownList1.Text + "', '" + DropDownList2.Text + "', '" + Result +"')";

            com = new SqlCommand(strInsert, con);
            com.ExecuteNonQuery();


            Result = "Name is : " + txtName.Text;
            Result += ",   Password is : " + txtPass.Text;
            Result += ",   Email ID is : " + txtEmail.Text;


            Result += ",   Gender is : " + RadioButtonList1.SelectedItem.ToString();
            Result += ",   Date is : " + ViewState["CDate"].ToString();

            if (chkCSE.Checked)
            {
                Result += ",   Course is :  " + chkCSE.Text;
            }
            if (chkMECH.Checked)
            {
                Result += ",   Course is :  " + chkMECH.Text;
            }
            if (chkECE.Checked)
            {
                Result += ",   Course is :  " + chkECE.Text;
            }

            Result += ",   State is : " + DropDownList1.SelectedItem.ToString();
            Result += ",   City is : " + DropDownList2.SelectedItem.ToString();

            Label3.Text = Result;

            Response.Redirect("Services.aspx?uname=" + txtName.Text);
        }

        protected void btnUpdate0_Click(object sender, EventArgs e)
        {
            string strupdate = "update QuoraRegister" + " set Name='" + txtName.Text + "',Password ='" + txtPass.Text + "',EmailID='" + txtEmail.Text + "',Gender='" + RadioButtonList1.Text + "',DOB='" + strDate + "',State='" + DropDownList1.Text + "',City='" + DropDownList2.Text + "',Course='" + Result + "'";
            com = new SqlCommand(strupdate, con);
            con.Open();
            com.ExecuteNonQuery();
            Response.Redirect("Services.aspx?uname=" + txtName.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string strdel = "delete from QuoraRegister" + " where Name ='" + txtName.Text + "'";
            com = new SqlCommand(strdel, con);
            con.Open();
            com.ExecuteNonQuery();
            Response.Redirect("Services.aspx?uname=" + txtName.Text);
        }
    }
}