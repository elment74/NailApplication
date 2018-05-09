using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NailApplication
{
    public partial class Appointments : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authenticate tempvar = (Authenticate)Session["MyVariable"];
            if (tempvar.approved() == false && tempvar.ad() == false)
            {
                Response.Redirect("Default.aspx");
            }

            string line = "";
            CheckBoxList1.Items.Clear();
            bool number = true;
            using (StreamReader _testData = new StreamReader(Server.MapPath("~/Appointments.txt"), true))

                while ((line = _testData.ReadLine()) != null)
                {

                    string[] temp = line.Split(' ');
                    if (temp[0] != DateTime.Now.ToString("MM/dd/yyy"))
                    {
                       
                       number = false;
                    }
                    if (number == true)
                    {
                        CheckBoxList1.Items.Add(line);
                    }


                    number = true;
                }


        }
    



        protected void Button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter _testData = new StreamWriter(Server.MapPath("~/Appointments.txt"), true))
            {
                _testData.WriteLine(Calendar1.SelectedDate.ToString("MM/dd/yyy") + " " + TextBox1.Text + " " + TextBox2.Text + " " + DropDownList1.SelectedValue + ":" + DropDownList2.SelectedValue);
            }
            TextBox1.Text = "";
            TextBox2.Text = "";

            string line = "";
            CheckBoxList1.Items.Clear();
            bool number = true;
            using (StreamReader _testData = new StreamReader(Server.MapPath("~/Appointments.txt"), true))

                while ((line = _testData.ReadLine()) != null)
                {

                    string[] temp = line.Split(' ');
                    if (temp[0] != DateTime.Now.ToString("MM/dd/yyy"))
                    {

                        number = false;
                    }
                    if (number == true)
                    {
                        CheckBoxList1.Items.Add(line);
                    }


                    number = true;
                }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}