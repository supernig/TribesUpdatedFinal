using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
       

    

  

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new AddUI();
            a.Show();

        

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var a = new EquipmentUI();

            var t = int.Parse(comboBox1.SelectedIndex.ToString());
            var i = t + 1;
            if (comboBox1.Text.Equals("") && comboBox2.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items where items.name like '%" + textBox1.Text + "%'", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text.Equals("") && comboBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.categoryID FROM items where items.name like '%" + textBox1.Text + "%' and items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox1.Text.Equals("") && comboBox2.Text!="")
            {
                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is"+a1+" FROM items where items.name like '%" + textBox1.Text + "%' " , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;

                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text != "" && comboBox1.Text != "" && textBox1.Text!="")
            {

                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items where items.name like '%" + textBox1.Text + "%' and items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;

                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text != "" && comboBox1.Text != "" && textBox1.Text == "")
            {

                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items where  items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;

                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            var t = int.Parse(comboBox1.SelectedIndex.ToString());
            var i = t + 1;
            var o = int.Parse(comboBox2.SelectedIndex.ToString());
            var p = o + 1;
            var a1 = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a1 = "DamagedBeyondRepair";
            }
            if (comboBox2.Text.Equals("Deployed"))
            {
                a1 = "DamagedBeyondRepair";
            }
            if (comboBox2.Text.Equals(""))
            {
                a1 = "Deployable";
            }
            if (comboBox2.Text.Equals("Rented"))
            {
                a1 = "Rented";
            }
            if (comboBox2.Text.Equals("Onrepair"))
            {
                a1 = "Onrepair";
            }
            if (comboBox2.Text.Equals("Damaged"))
            {
                a1 = "Damaged";
            }
            if (comboBox2.Text.Equals("Deployable"))
            {
                a1 = "Deployable";
            }

            var a = new EquipmentUI();
            if (comboBox1.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
               
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items  ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }



            if (comboBox1.Text.Equals("") && textBox1.Text != "")
            {


                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items  where items.name like '%" + textBox1.Text + "%' ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (textBox1.Text.Equals("") &&comboBox1.Text!="")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.categoryID FROM items  where  items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }




         if(comboBox1.Text!="" && comboBox2.Text!="" &&textBox1.Text!="")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.categoryID FROM items  where items.name like '%" + textBox1.Text + "%' and items.categoryID=" + i , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = int.Parse(comboBox1.SelectedIndex.ToString());
            var i = t + 1;
  
            var a1 = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a1 = "DamagedBeyondRepair";
            }
            else
            {
                a1 = comboBox2.Text;
            }
            var a = new EquipmentUI();
            if (comboBox2.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.categoryID FROM items where categoryID= "+i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }



            if (comboBox2.Text.Equals("") && !textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.categoryID FROM items  where items.name like '%" + textBox1.Text + "%' and categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (textBox1.Text.Equals("") && !comboBox2.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.categoryID FROM items  where  items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }




            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=root;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.categoryID FROM items  where items.name like '%" + textBox1.Text + "%' and items.categoryID=" + i, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=db";
            var a = new EquipmentUI();
            a.dataGridView1.DefaultCellStyle.SelectionBackColor = a.dataGridView1.DefaultCellStyle.BackColor;
            a.dataGridView1.DefaultCellStyle.SelectionForeColor = a.dataGridView1.DefaultCellStyle.ForeColor;
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

                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.DataSource = dt;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ReadOnly = false;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.ClearSelection();
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[2].Visible = false;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].HeaderCell.Value = "";
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[1].Width = 50;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].HeaderCell.Value = "";
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[0].Width = 50;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).dataGridView1.Refresh();
                        }
                    }
                }
            }




        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }

    
}
