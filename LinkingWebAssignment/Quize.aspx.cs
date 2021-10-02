using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkingWebAssignment
{
    public partial class Quize : System.Web.UI.Page
    {

        //Quize Game Variable
        string correctAnswer;
        int count=1;
        int score;
        int ques=1;
        //Random rnd = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            // ques = rnd.Next(1, 10);
            askQuestion(ques);

        }

        protected void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            string button = senderObject.Text;
            
            if (button == correctAnswer)
            {
                score = score + 1;
            }
            lblScore.Text = score.ToString();

            if (count == 10)
            {
                Response.Redirect("Finish.aspx?uScore=" + lblScore.Text);
            }

            ques++;
            askQuestion(ques);
            count = count + 1;
            Label5.Text = count.ToString();
        }
        
        
        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    lblQuestion.Text = "Which object contains the Position property of the current record in a dataset";
                    btnAns1.Text = "BindingContext";
                    btnAns2.Text = "BindingData";
                    btnAns3.Text = "DataBinding";
                    btnAns4.Text = "DataBound";

                    correctAnswer = "BindingContext";
                    break;

                case 2:
                    lblQuestion.Text = "Which method in OLEDB adapter is used to populate dataset with records";
                    btnAns1.Text = "PutMethod";
                    btnAns2.Text = "FillMethod";
                    btnAns3.Text = "FillsMethod";
                    btnAns4.Text = "InsertMethod";

                     correctAnswer = "FillMethod";
                    break;

                case 3:
                    lblQuestion.Text = "What is the use of SQL command object";
                    btnAns1.Text = "XML";
                    btnAns2.Text = "HTML";
                    btnAns3.Text = "PHP";
                    btnAns4.Text = "JAVASCRIPT";

                    correctAnswer = "XML";
                    break;

                case 4:
                    lblQuestion.Text = "The first record in a dataset has a property of";
                    btnAns1.Text = "Zero";
                    btnAns2.Text = "One";
                    btnAns3.Text = "AnyValue";
                    btnAns4.Text = "AllOfAbove";

                    correctAnswer = "Zero";
                    break;

                case 5:
                    lblQuestion.Text = "Which ADO.NET class provide disconnected environment";
                    btnAns1.Text = "DataReader";
                    btnAns2.Text = "Command";
                    btnAns3.Text = "DataSet";
                    btnAns4.Text = "NoneOfAbove";

                    correctAnswer = "DataSet";
                    break;

                case 6:
                    lblQuestion.Text = "Data provider which is not supported by the ADO.NET";
                    btnAns1.Text = "ODBC";
                    btnAns2.Text = "MsSQLServer";
                    btnAns3.Text = "OLEDB";
                    btnAns4.Text = "MyAccess";

                    correctAnswer = "MyAccess";
                    break;

                case 7:
                    lblQuestion.Text = "Class which is not available in System.Data namespace";
                    btnAns1.Text = "DataTable";
                    btnAns2.Text = "DataRecord";
                    btnAns3.Text = "DataColumn";
                    btnAns4.Text = "DataRow";

                    correctAnswer = "DataRecord";
                    break;

                case 8:
                    lblQuestion.Text = "Keyword is used to accept variable number of parameters";
                    btnAns1.Text = "Programs";
                    btnAns2.Text = "Param";
                    btnAns3.Text = "Parameters";
                    btnAns4.Text = "Params";

                    correctAnswer = "Params";
                    break;

                case 9:
                    lblQuestion.Text = "Method is which is used to read XML file";
                    btnAns1.Text = "ReadXMLSchema()";
                    btnAns2.Text = "GetXMl()";
                    btnAns3.Text = "ReadXML()";
                    btnAns4.Text = "ViewXML()";

                    correctAnswer = "GetXMl()";
                    break;

                case 10:
                    lblQuestion.Text = "SQL Client provideris used to access only ______ database";
                    btnAns1.Text = "SQLServer";
                    btnAns2.Text = "MySQLServer";
                    btnAns3.Text = "WampServer";
                    btnAns4.Text = "MyServer";

                    correctAnswer = "SQLServer";
                    break;
                    
            }
        }
    }
}