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
    public partial class EditUI : Form
    {
        public EditUI()
        {
            InitializeComponent();
        }
        public string u;
        private void Form4_Load(object sender, EventArgs e)
        {
          
            TextBox1.Text = (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).Label2.Text;
           ComboBox1.Text = (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).Label4.Text;
       
        }

        private void Button1_Click(object sender, EventArgs e)
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
        
     
            var x = int.Parse(ComboBox1.SelectedIndex.ToString());
            var i = x + 1;
          
           
                if (TextBox1.Text == "")
                {
                    MessageBox.Show("Dont leave name blank.", "Error. ",
MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(myConnectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(" UPDATE `db`.`items` SET `name`='" + TextBox1.Text + "',`stocks`=0,`categoryID`=" + i + ",`description`='" + TextBox2.Text + "',`isDeployable`=0,`isDamaged`=0,`isOnrepair`=0,`isRented`=0,`isDeployed`=0,`isDamagedBeyondRepair`=0 WHERE (`id` = '" + EquipmentUI.sendtext + "');", conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Successfully updated to database.", "Successful. ",
MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                (System.Windows.Forms.Application.OpenForms["ViewUI"] as ViewUI).Close();
                                this.Close();
                                (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).refreshni();
                            }
                        }
                    }
                }

            

            
            conn.Close();
        }

        private void dbr_TextChanged(object sender, EventArgs e)
        {
           
        
           
        }

      


        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void onpress(object sender, KeyEventArgs e)
        {
           
        }

        private void dbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dbr_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            var a = 0;

            var first = TextBox3.Text;
            var x = 0;



            if (int.TryParse(dbr.Text, out x) && e.KeyCode != Keys.Back)
            {
                if (dbr.Text != "")
                {
                    if(dbr.Text.Length == 1)
                    {
                        a = int.Parse(u) - int.Parse(dbr.Text);
                        TextBox3.Text = a.ToString();
                    }
                    if (dbr.Text.Length > 1)
                    {
                        a = int.Parse(u) - int.Parse(dbr.Text);
                        TextBox3.Text = a.ToString();
                    }



                }
                else
                {
                    TextBox3.Text = first;

                }
            }
      


            if (!int.TryParse(dbr.Text, out x) && dbr.Text != "")
            {
                MessageBox.Show("Inputs here must be a digit", "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            */
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
