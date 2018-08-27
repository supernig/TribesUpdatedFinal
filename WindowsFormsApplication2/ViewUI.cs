﻿using System;
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
        public static string forEdit = "";
        public static string forEditID = "";
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

            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            conn.ConnectionString = myConnectionString;
            conn.Open();
         
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext, conn))
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure?" , "Pls Dont :'(", MessageBoxButtons.YesNo);
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
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,itemcontent.modelNumber,itemcontent.id from items left join itemcontent on items.id = itemcontent.itemID where items.id =" + EquipmentUI.sendtext, conn))
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
                                                    MessageBox.Show("Data Deleted!", "Successful ",
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
    }
}
