using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NailApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authenticate tempvar = (Authenticate)Session["MyVariable"];
            if (tempvar.approved() == true) 
            {
                Label1.Text = "Logged in";
            }
            else if(tempvar.ad() == true)
            {
                Label1.Text = "Admin logged in";
            }
            else
            {
                Label1.Text = "Please login with code";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Appointments.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Authenticate tempvar = (Authenticate)Session["MyVariable"];
            bool temp = tempvar.login(Convert.ToInt32(TextBox3.Text));
            if(temp == true)
            {
                Label1.Text = "Logged in";
            }
            else
            {
                Label1.Text = "Failed to log in";
            }
        }
    }
}