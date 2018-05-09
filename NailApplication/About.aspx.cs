using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NailApplication
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Authenticate tempvar = (Authenticate)Session["MyVariable"];
            if (tempvar.approved() == false && tempvar.ad() == false)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            int temp = Int32.Parse(e.Item.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();

            ListItem item = new ListItem
            {
                Text = e.Item.Text,
                Value = e.Item.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            return;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string temp = "";
            foreach (ListItem li in CheckBoxList1.Items)
            {
                temp += li.Text + " ";
            }
            using (StreamWriter _testData = new StreamWriter(Server.MapPath("~/data.txt"), true))
            {
                _testData.WriteLine(DropDownList1.Text + " "  + TextBox1.Text + " " + TextBox2.Text + " " + temp + DateTime.Now);
            }

            TextBox1.Text = "0";
            TextBox2.Text = "0";
            CheckBoxList1.Items.Clear();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            int temp = Int32.Parse(DropDownList2.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();
            

            ListItem item = new ListItem
            {
                Text = DropDownList2.SelectedItem.Text,
                Value = DropDownList2.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }

            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            CheckBoxList1.Items.Clear();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList3.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList3.SelectedItem.Text,
                Value = DropDownList3.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList4.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList4.SelectedItem.Text,
                Value = DropDownList4.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList5.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList5.SelectedItem.Text,
                Value = DropDownList5.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList6.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList6.SelectedItem.Text,
                Value = DropDownList6.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList7.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList7.SelectedItem.Text,
                Value = DropDownList7.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList8.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList8.SelectedItem.Text,
                Value = DropDownList8.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList9.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList9.SelectedItem.Text,
                Value = DropDownList9.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList10.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList10.SelectedItem.Text,
                Value = DropDownList10.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList11.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList11.SelectedItem.Text,
                Value = DropDownList11.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(DropDownList12.SelectedItem.Value);
            temp = temp + Int32.Parse(TextBox1.Text);
            TextBox1.Text = temp.ToString();


            ListItem item = new ListItem
            {
                Text = DropDownList12.SelectedItem.Text,
                Value = DropDownList12.SelectedItem.Value
            };
            CheckBoxList1.Items.Add(item);

            foreach (ListItem li in CheckBoxList1.Items)
            {
                li.Selected = true;
            }
        }
    }
}