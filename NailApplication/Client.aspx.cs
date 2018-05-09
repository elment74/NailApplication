using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NailApplication
{
    public partial class Client : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            Authenticate tempvar = (Authenticate)Session["MyVariable"];
            if (tempvar.approved() == false && tempvar.ad() == false)
            {
                Response.Redirect("Default.aspx");
            }



        }
    




        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {

            }
            else
            {
                if (string.IsNullOrWhiteSpace(TextBox2.Text))
                {
                    TextBox2.Text = "Empty";
                }
                if (string.IsNullOrWhiteSpace(TextBox3.Text))
                {
                    TextBox3.Text = "Empty";
                }
                if (string.IsNullOrWhiteSpace(TextBox4.Text))
                {
                    TextBox4.Text = "Empty";
                }
                if (string.IsNullOrWhiteSpace(TextBox5.Text))
                {
                    TextBox5.Text = "Empty";
                }

                using (StreamWriter _testData = new StreamWriter(Server.MapPath("~/client.txt"), true))
                {
                    _testData.WriteLine(TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text + " " + TextBox4.Text + " " + TextBox5.Text);
                }
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string line = "";
            bool number = true;
            using (StreamReader _testData = new StreamReader(Server.MapPath("~/client.txt"), true))
                if (string.IsNullOrWhiteSpace(TextBox6.Text))
                {

                }
                else
                {
                    while ((line = _testData.ReadLine()) != null)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (line[i] != TextBox6.Text[i])
                            {
                                number = false;
                            }
                        }
                        if (number == true)
                        {
                            TextBox7.Text = line;
                            
                        }
                       


                    }
                    number = true;
                }
        }
    }
}