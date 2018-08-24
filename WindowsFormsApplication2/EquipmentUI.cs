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
    public partial class EquipmentUI : Form
    {
        public EquipmentUI()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }


        public static string sendtext = "";
        
         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=db";

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                   
                    var a = new ViewUI();
                    sendtext = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
                    a.Show();
                 
                }
                if (e.ColumnIndex == 1)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                    using (MySqlConnection con = new MySqlConnection(myConnectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE id =" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            if (cmd.ExecuteNonQuery() > 0 )
                            {
                         


                                using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                {
                                    using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                                    {
                                        cmd1.CommandType = CommandType.Text;
                                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                                        {
                                            using (DataTable dt = new DataTable())
                                            {
                                                sda.Fill(dt);
                                                dataGridView1.DataSource = dt;
                                                dataGridView1.ReadOnly = false;
                                                dataGridView1.ClearSelection();
                                                dataGridView1.Columns[2].Visible = false;
                                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[4].HeaderCell.Value = "Stocks";
                                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                                dataGridView1.Columns[1].Width = 50;
                                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                                dataGridView1.Columns[0].Width = 50;
                                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                MessageBox.Show("Data Deleted!", "Successful ",
MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    conn.Close();

                }
            }
        }
         public  void refreshni()
         {
             MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
             string myConnectionString;
             myConnectionString = "server=127.0.0.1;"
 + "uid=root;"
 + "pwd=root;"
 + "SslMode=none;"
 + "database=db";
             var a = new EquipmentUI();
             dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
             dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
             conn.ConnectionString = myConnectionString;
             conn.Open();
             using (MySqlConnection con = new MySqlConnection(myConnectionString))
             {
                 using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                 {
                     cmd.CommandType = CommandType.Text;
                     using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                     {
                         using (DataTable dt = new DataTable())
                         {
                             sda.Fill(dt);
                             dataGridView1.DataSource = dt;
                             dataGridView1.ReadOnly = false;
                             dataGridView1.ClearSelection();
                             dataGridView1.Columns[2].Visible = false;
                             dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[3].HeaderCell.Value = "Name";
                             dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                             dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[1].HeaderCell.Value = "";
                             dataGridView1.Columns[1].Width = 50;
                             dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[0].HeaderCell.Value = "";
                             dataGridView1.Columns[0].Width = 50;
                             dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                             dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                         }
                     }
                 }
             }
        }

     
     
         public void Form1_Load(object sender, EventArgs e)
         {
            
           
             MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
             string myConnectionString;
             myConnectionString = "server=127.0.0.1;"
 + "uid=root;"
 + "pwd=root;"
 + "SslMode=none;"
 + "database=db";
             var a = new EquipmentUI();
             dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
             dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
             conn.ConnectionString = myConnectionString;
             conn.Open();
             using (MySqlConnection con = new MySqlConnection(myConnectionString))
             {
                 using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                 {
                     cmd.CommandType = CommandType.Text;
                     using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                     {
                         using (DataTable dt = new DataTable())
                         {
                           
                             sda.Fill(dt);
                             dataGridView1.DataSource = dt;
                             dataGridView1.ReadOnly = false;
                             dataGridView1.ClearSelection();
                             dataGridView1.Columns[2].Visible = false;
                             dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[3].HeaderCell.Value = "Name";
                             dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                             dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[1].HeaderCell.Value = "";
                             dataGridView1.Columns[1].Width = 50;
                             dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                             dataGridView1.Columns[0].HeaderCell.Value = "";
                             dataGridView1.Columns[0].Width = 50;
                             dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                             dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                         }
                     }
                 }
             }
         }

         private void userControl11_Load_1(object sender, EventArgs e)
         {

         }

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }
    }
    }


