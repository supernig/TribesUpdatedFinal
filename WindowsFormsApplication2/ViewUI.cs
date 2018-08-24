using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ViewUI : Form
    {
        public ViewUI()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var a = new EditUI();
            a.Show();
        }

        private void dep_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void dbr_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }
        public string c;
        private void Form3_Load(object sender, EventArgs e)
        {
            var a = new EquipmentUI();
   


            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=db";

            conn.ConnectionString = myConnectionString;
            conn.Open();

            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,category.description,items.description,items.isDeployable,items.isDamaged,items.isOnrepair,items.isRented,items.isDeployed,items.isDamagedBeyondRepair FROM items left join category on items.categoryID = category.id where items.id =" + EquipmentUI.sendtext, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        MySqlDataReader myreader = cmd.ExecuteReader();
                        if (myreader.Read())
                        {
                            Label2.Text = myreader.GetValue(1).ToString();
                            Label4.Text = myreader.GetValue(3).ToString();
                            Label8.Text = myreader.GetValue(2).ToString();
                            if (myreader.GetValue(4).ToString()=="")
                            {
                                Label6.Text = "Not specified";
                            }
                            else
                            {
                                Label6.Text = myreader.GetValue(4).ToString();
                            }

                            Label13.Text = myreader.GetValue(5).ToString();
                            Label14.Text = myreader.GetValue(6).ToString();
                            Label15.Text = myreader.GetValue(7).ToString();
                            Label16.Text = myreader.GetValue(8).ToString();
                            dep.Text = myreader.GetValue(9).ToString();
                            dbr.Text = myreader.GetValue(10).ToString();
                            this.Text = myreader.GetValue(1).ToString();
                        }
                        myreader.Close();
                    }
                }
            }
            conn.Close();


        }
    }
}
