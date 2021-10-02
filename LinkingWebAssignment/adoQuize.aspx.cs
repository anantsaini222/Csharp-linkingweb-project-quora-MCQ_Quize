using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkingWebAssignment
{
    public partial class adoQuize : System.Web.UI.Page
    {

        int h = 0;
        int score = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = score.ToString();

        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            btn_next.Enabled = false;
            btn_next.BackColor = Color.Red;
            btn_check.Enabled = true;
            btn_check.BackColor = Color.Green;

            if(h==1)
            {
                h1question.Text = "OHk";
                ans1.Text = "A) a";
                ans2.Text = "B) b";
                ans3.Text = "C) c";
                ans4.Text = "D) d";
            }

            if (h == 2) 
            {
                h1question.Text = "ooh God";
                ans1.Text = "A) a";
                ans2.Text = "B) b";
                ans3.Text = "C) c";
                ans4.Text = "D) d";
            }

            if (h==3)
            {

            }

        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            btn_next.Enabled = true;
            btn_next.BackColor = Color.Green;
            btn_check.Enabled = false;
            btn_check.BackColor = Color.Red;

            if (h1question.Text == "OHk")
            {
                if (ans1.Checked == true)
                {
                    score++;
                }
            }
            if (h1question.Text == "ooh God")
            {
                if(ans2.Checked==true)
                {
                    score++;
                }
            }
        }
    }
}