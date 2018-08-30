using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=db";
            conn.ConnectionString = myConnectionString;
            conn.Open();
            var x = comboBox1.SelectedIndex + 1;

            using (MySqlCommand cmd1 = new MySqlCommand("Select COUNT(*) FROM itemcontent where modelNumber ='" + textBox1.Text + "' and itemID =" + EquipmentUI.sendtext, conn))
            {
                cmd1.CommandType = CommandType.Text;
                MySqlDataReader myreader = cmd1.ExecuteReader();
                var i = 0;
                if (myreader.Read())
                {
                    i = int.Parse(myreader.GetValue(0).ToString());

                }
                myreader.Close();
                if (i > 0 && x != 2)
                {
                    MessageBox.Show("No change detected or another item exists with the same name in the database.", "Error. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
              
                else
                {


                    if (textBox1.Text == "" )
                    {
                        MessageBox.Show("Dont leave name blank.", "Error. ",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(" UPDATE itemcontent SET modelNumber='" + textBox1.Text + "' , tagID = "+x+" WHERE itemID = '" + EquipmentUI.sendtext + "' and id ="+ViewUI.forEditID, conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Successfully updated to database.", "Successful. ",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    (System.Windows.Forms.Application.OpenForms["Form2"] as Form2).Close();
                                 
                                    (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).refreshni();
                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.DefaultCellStyle.BackColor;
                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.DefaultCellStyle.ForeColor;


                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID < 2", conn))
                                        {
                                            cmd.CommandType = CommandType.Text;
                                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                            {
                                                using (DataTable dt = new DataTable())
                                                {

                                                    sda.Fill(dt);
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.DataSource = dt;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.ReadOnly = false;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.ClearSelection();
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[2].Visible = false;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[4].Visible = false;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[3].HeaderCell.Value = "Name / Model Number";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[1].Width = 50;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[0].Width = 50;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                                                }
                                            }
                                        }
                                    }


                           


                                    using (MySqlConnection con5 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd5 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id,damagelogs.datedamaged from items left join itemcontent on items.id = itemcontent.itemID inner JOIN damagelogs on  itemcontent.id = damagelogs.itemid where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 2 and damagelogs.datedamaged != '0000-00-00'", conn))
                                        {                                                                                       //SELECT damagelogs.daterdamaged,itemcontent.modelNumber from repairlogs inner JOIN itemcontent on  itemcontent.id = repairlogs.itemID where itemcontent.itemID = " + EquipmentUI.sendtext + " and repairlogs.daterepaired != '0000-00-00'
                                            cmd5.CommandType = CommandType.Text;
                                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd5))
                                            {
                                                using (DataTable dt = new DataTable())
                                                {

                                                    sda.Fill(dt);
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DataSource = dt;

                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.ClearSelection();
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].Visible = false;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[3].Visible = false;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].HeaderCell.Value = "Name / Model Number";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].HeaderCell.Value = "";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].Width = 50;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].HeaderCell.Value = "";
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].Width = 100;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                    (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                }
                                            }
                                        }
                                    }






                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySqlCommand cmd2 = new MySqlCommand(" INSERT INTO `db`.`damagelogs` (`itemID`, `datedamaged`) VALUES ('" + ViewUI.forEditID + "',  '" + DateTime.Now + "')", conn))
                                        {
                                            cmd2.CommandType = CommandType.Text;
                                            if (cmd2.ExecuteNonQuery() > 0)
                                            {


                                    
                                                using (MySqlConnection con2 = new MySqlConnection(myConnectionString))
                                                {
                                                    using (MySql.Data.MySqlClient.MySqlCommand cmd4 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id,damagelogs.datedamaged from items left join itemcontent on items.id = itemcontent.itemID inner JOIN damagelogs on  itemcontent.id = damagelogs.itemid where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 2 and damagelogs.datedamaged != '0000-00-00'", conn))
                                                    {
                                                        cmd4.CommandType = CommandType.Text;
                                                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd4))
                                                        {
                                                            using (DataTable dt = new DataTable())
                                                            {

                                                                sda.Fill(dt);
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.DataSource = dt;

                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.ClearSelection();
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].Visible = false;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[3].Visible = false;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].HeaderCell.Value = "Name / Model Number";
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].HeaderCell.Value = "";
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[1].Width = 50;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].HeaderCell.Value = "";
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[0].Width = 100;
                                                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        

                    }

                }
            }


            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = ViewUI.forEdit;
            comboBox1.SelectedIndex =0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
