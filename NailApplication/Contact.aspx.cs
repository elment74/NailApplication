using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NailApplication
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string line = "";
            using (StreamReader _testData = new StreamReader(Server.MapPath("~/data.txt"), true))

                while ((line = _testData.ReadLine()) != null)
                {
                    CheckBoxList1.Items.Add(line);

                    
                }



        }
    


        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}