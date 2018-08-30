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
//dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() 
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
        public static string forEdit = "";
        public static string forEditID = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
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
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,category.description,items.description,items.isDeployable,items.isDamaged,items.isOnrepair,items.isRented,items.isDeployed,items.isDamagedBeyondRepair FROM items left join category on items.categoryID = category.id where items.id =" + EquipmentUI.sendtext , conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        MySqlDataReader myreader = cmd.ExecuteReader();
                        if (myreader.Read())
                        {
                            Label2.Text = myreader.GetValue(1).ToString();
                            Label4.Text = myreader.GetValue(3).ToString();
                           
                            if (myreader.GetValue(4).ToString()=="")
                            {
                                Label6.Text = "Not specified";
                            }
                            else
                            {
                                Label6.Text = myreader.GetValue(4).ToString();
                            }

                         
                            this.Text = myreader.GetValue(1).ToString();
                        }
                        myreader.Close();
                    }
                }
            }
            conn.Close();

            
            conn.ConnectionString = myConnectionString;
            conn.Open();
         
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID < 2", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            sda.Fill(dt);
                            
                            dataGridView1.DataSource = dt;
                          
                            dataGridView1.ClearSelection();
                            dataGridView1.Columns[2].Visible = false;
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView1.Columns[3].HeaderCell.Value = "Name / Model Number";
                            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView1.Columns[1].HeaderCell.Value = "";
                            dataGridView1.Columns[1].Width = 50;
                            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView1.Columns[0].HeaderCell.Value = "";
                            dataGridView1.Columns[0].Width = 50;
                            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                  
                        }
                    }
                }
            }

            conn.Close();

            conn.ConnectionString = myConnectionString;
            conn.Open();

            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id,damagelogs.datedamaged from items left join itemcontent on items.id = itemcontent.itemID inner JOIN damagelogs on  itemcontent.id = damagelogs.itemid where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 2 and damagelogs.datedamaged != '0000-00-00'", conn))
                {                                                                                       //SELECT damagelogs.daterdamaged,itemcontent.modelNumber from repairlogs inner JOIN itemcontent on  itemcontent.id = repairlogs.itemID where itemcontent.itemID = " + EquipmentUI.sendtext + " and repairlogs.daterepaired != '0000-00-00'
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            sda.Fill(dt);
                            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                            dataGridView2.DataSource = dt;
                           
                            dataGridView2.ClearSelection();
                            dataGridView2.Columns[1].Visible = false;
                            dataGridView2.Columns[3].Visible = false;
                            dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView2.Columns[2].HeaderCell.Value = "Name / Model Number";
                            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                            dataGridView2.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
                            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView2.Columns[1].HeaderCell.Value = "";
                            dataGridView2.Columns[1].Width = 50;
                            dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView2.Columns[0].HeaderCell.Value = "";
                            dataGridView2.Columns[0].Width = 100;
                            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView2.Columns[4].HeaderCell.Value = "Date & Time";
                            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }


            conn.Close();
           
            conn.ConnectionString = myConnectionString;
            conn.Open();

            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 3", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            sda.Fill(dt);
                            
                            dataGridView3.DataSource = dt;
                            
                            dataGridView3.ClearSelection();
                            dataGridView3.Columns[1].Visible = false;
                            dataGridView3.Columns[3].Visible = false;
                            dataGridView3.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView3.Columns[2].HeaderCell.Value = "Name / Model Number";
                            dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView3.Columns[1].HeaderCell.Value = "";
                            dataGridView3.Columns[1].Width = 50;
                            dataGridView3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView3.Columns[0].HeaderCell.Value = "";
                            dataGridView3.Columns[0].Width = 100;
                            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                    }
                }
            }

            conn.Close();

            conn.ConnectionString = myConnectionString;
            conn.Open();

          

                        using (MySqlConnection con2 = new MySqlConnection(myConnectionString))
                        {
                            using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT repairlogs.daterepaired,itemcontent.modelNumber from repairlogs inner JOIN itemcontent on  itemcontent.id = repairlogs.itemID where itemcontent.itemID = " + EquipmentUI.sendtext + " and repairlogs.daterepaired != '0000-00-00'", conn))
                            {
                                cmd2.CommandType = CommandType.Text;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                {
                                    using (DataTable dt = new DataTable())
                                    {

                                        sda.Fill(dt);
                                        
                                        dataGridView4.DataSource = dt;
                                        dataGridView4.ClearSelection();

                                        dataGridView4.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        dataGridView4.Columns[1].HeaderCell.Value = "Name / Model Number";
                                        dataGridView4.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        dataGridView4.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                                        dataGridView4.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        dataGridView4.Columns[0].HeaderCell.Value = "Date & Time";
                                        dataGridView4.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                        dataGridView4.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                                        dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                        dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    }
                                }
                            }
                        }
                    
                
            



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

                    var a = new Form2();
                    forEdit = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    forEditID = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    a.Show();

                }
                if (e.ColumnIndex == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure?" , "Processing...;", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something


                        conn.ConnectionString = myConnectionString;
                        conn.Open();
                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM itemcontent WHERE id ='"+ dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "' and itemID ="+EquipmentUI.sendtext , conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {



                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 1", conn))
                                        {
                                            cmd1.CommandType = CommandType.Text;
                                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                                            {
                                                using (DataTable dt = new DataTable())
                                                {
                                                    sda.Fill(dt);
                                                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                                                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                                                    dataGridView1.DataSource = dt;
                                               
                                                    dataGridView1.ClearSelection();
                                                    dataGridView1.Columns[2].Visible = false;
                                                    dataGridView1.Columns[4].Visible = false;
                                                    dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[3].HeaderCell.Value = "Name / Model Number";
                                                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                                                    dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[1].HeaderCell.Value = "";
                                                    dataGridView1.Columns[1].Width = 50;
                                                    dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[0].HeaderCell.Value = "";
                                                    dataGridView1.Columns[0].Width = 50;
                                                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                    MessageBox.Show("Successful!", "Successful ",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new Form1();
            a.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               var senderGrid = (DataGridView)sender;
               if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
               {
                   if (e.ColumnIndex == 0)
                   {

                       DialogResult dialogResult = MessageBox.Show("Are you sure?", "Processing...;", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                       if (dialogResult == DialogResult.No)
                       {
                           //do something else
                       }
                       else
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
                            
                                       using (MySqlConnection con = new MySqlConnection(myConnectionString))
                                       {
                                           using (MySqlCommand cmd = new MySqlCommand(" UPDATE itemcontent SET  tagID = 3 WHERE itemID = '" + EquipmentUI.sendtext + "' and id = " + dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(), conn))
                                           {
                                               cmd.CommandType = CommandType.Text;
                                               if (cmd.ExecuteNonQuery() > 0)
                                               {
                                                   MessageBox.Show("Successfully MOVED to on repair.", "Successful. ",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                               


                                                   using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                                   {
                                                       using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 2", conn))
                                                       {
                                                           cmd.CommandType = CommandType.Text;
                                                           using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                                           {
                                                               using (DataTable dt = new DataTable())
                                                               {

                                                               
                                                                   sda.Fill(dt);
                                                                  dataGridView2.DataSource = dt;
                                                   
                                                                   dataGridView2.ClearSelection();
                                                                   dataGridView2.Columns[1].Visible = false;
                                                                   //dataGridView2.Columns[3].Visible = false;
                                                                   dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView2.Columns[2].HeaderCell.Value = "Name / Model Number";
                                                                   dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                                                                   dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView2.Columns[1].HeaderCell.Value = "";
                                                                   dataGridView2.Columns[1].Width = 50;
                                                                   dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView2.Columns[0].HeaderCell.Value = "";
                                                                   dataGridView2.Columns[0].Width = 100;
                                                                   dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                                                               }
                                                           }
                                                       }
                                                   }

                                                   using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                                   {
                                                       using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 3", conn))
                                                       {
                                                           cmd.CommandType = CommandType.Text;
                                                           using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                                           {
                                                               using (DataTable dt = new DataTable())
                                                               {


                                                                   sda.Fill(dt);
                                                                  dataGridView3.DataSource = dt;
                                                              
                                                                   dataGridView3.ClearSelection();
                                                                   dataGridView3.Columns[1].Visible = false;
                                                                   //dataGridView2.Columns[3].Visible = false;
                                                                   dataGridView3.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView3.Columns[2].HeaderCell.Value = "Name / Model Number";
                                                                   dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView3.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                                                                   dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView3.Columns[1].HeaderCell.Value = "";
                                                                   dataGridView3.Columns[1].Width = 50;
                                                                   dataGridView3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                   dataGridView3.Columns[0].HeaderCell.Value = "";
                                                                   dataGridView3.Columns[0].Width = 100;
                                                                   dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
               
               }//do something

        }
        public string tester = "";
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tester = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {


                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Processing...;", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    else
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

                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(" UPDATE itemcontent SET  tagID = 1 WHERE itemID = '" + EquipmentUI.sendtext + "' and id = " + dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString(), conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Successfully MOVED to on repair.", "Successful. ",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);





                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 3", conn))
                                        {
                                            cmd.CommandType = CommandType.Text;
                                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                            {
                                                using (DataTable dt = new DataTable())
                                                {


                                                    sda.Fill(dt);
                                                    dataGridView3.DataSource = dt;

                                                    dataGridView3.ClearSelection();
                                                    dataGridView3.Columns[1].Visible = false;
                                                    //dataGridView2.Columns[3].Visible = false;
                                                    dataGridView3.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView3.Columns[2].HeaderCell.Value = "Name / Model Number";
                                                    dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView3.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
                                                    dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView3.Columns[1].HeaderCell.Value = "";
                                                    dataGridView3.Columns[1].Width = 50;
                                                    dataGridView3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView3.Columns[0].HeaderCell.Value = "";
                                                    dataGridView3.Columns[0].Width = 100;
                                                    dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                                                }
                                            }
                                        }
                                    }


                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext + " and itemcontent.tagID = 1", conn))
                                        {
                                            cmd1.CommandType = CommandType.Text;
                                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                                            {
                                                using (DataTable dt = new DataTable())
                                                {
                                                    sda.Fill(dt);
                                                    dataGridView1.DataSource = dt;
                                                  
                                                    dataGridView1.ClearSelection();
                                                    dataGridView1.Columns[2].Visible = false;
                                                    dataGridView1.Columns[4].Visible = false;
                                                    dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[3].HeaderCell.Value = "Name / Model Number";
                                                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
                                                    dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[1].HeaderCell.Value = "";
                                                    dataGridView1.Columns[1].Width = 50;
                                                    dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                    dataGridView1.Columns[0].HeaderCell.Value = "";
                                                    dataGridView1.Columns[0].Width = 50;
                                                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                 
                                                }
                                            }
                                        }
                                    }


                                    using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                    {
                                        using (MySqlCommand cmd1 = new MySqlCommand(" INSERT INTO `db`.`repairlogs` (`itemID`, `daterepaired`) VALUES ('" + tester + "',  '" + DateTime.Now + "')", conn))
                                        {
                                            cmd1.CommandType = CommandType.Text;
                                            if (cmd1.ExecuteNonQuery() > 0)
                                            {
                                                using (MySqlConnection con2 = new MySqlConnection(myConnectionString))
                                                {
                                                    using (MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT repairlogs.daterepaired,itemcontent.modelNumber from repairlogs inner JOIN itemcontent on  itemcontent.id = repairlogs.itemID where itemcontent.itemID = " + EquipmentUI.sendtext + " and repairlogs.daterepaired != '0000-00-00'", conn))
                                                    {
                                                        cmd1.CommandType = CommandType.Text;
                                                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd2))
                                                        {
                                                            using (DataTable dt = new DataTable())
                                                            {

                                                                sda.Fill(dt);
                                                            
                                                                dataGridView4.DataSource = dt;

                                                                dataGridView4.ClearSelection();
                                                                dataGridView4.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                dataGridView4.Columns[1].HeaderCell.Value = "Name / Model Number";
                                                                dataGridView4.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                dataGridView4.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
                                                                dataGridView4.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                dataGridView4.Columns[0].HeaderCell.Value = "Name / Model Number";
                                                                dataGridView4.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                dataGridView4.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                                                                dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                                dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

                }

            }//do something

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
