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
    public partial class Form1 : Form
    {
        public Form1()
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
            using (MySqlCommand cmd1 = new MySqlCommand("Select COUNT(*) FROM itemcontent where modelNumber ='" + textBox1.Text + "' and itemID ="+EquipmentUI.sendtext, conn))
            {
                cmd1.CommandType = CommandType.Text;
                MySqlDataReader myreader = cmd1.ExecuteReader();
                var i = 0;
                if (myreader.Read())
                {
                    i = int.Parse(myreader.GetValue(0).ToString());

                }
                myreader.Close();
                if (i > 0)
                {
                    MessageBox.Show("Item already existed.", "Error. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
               
              
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Dont leave input blanks.", "Error. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(" INSERT INTO `db`.`itemcontent` (`itemID`, `tagID`, `modelNumber`, `StockID`) VALUES ('"+EquipmentUI.sendtext+"', '1', '"+ textBox1.Text + "', '0')", conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Successfully added to database.", "Successful. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                    this.Close();
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
                                }
                            }
                        }
                    }
                }


            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
