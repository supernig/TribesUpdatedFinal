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
 

    public partial class AddUI : Form 
    {
      
        public AddUI(){
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
            using (MySqlCommand cmd1 = new MySqlCommand("Select COUNT(*) FROM items where name ='" + textBox1.Text + "'", conn))
            {
                cmd1.CommandType = CommandType.Text;
                MySqlDataReader myreader = cmd1.ExecuteReader();
                var i=0;
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
                    var u = int.Parse(comboBox1.SelectedIndex.ToString());
                    var o = u + 1;
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Dont leave input blanks.", "Error. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(" INSERT INTO `db`.`items` (`name`,`categoryID`,`tagID`,`stocks`,`isDeployable`,`isDamaged`,`isOnrepair`,`isRented`,`isDeployed`,`isDamagedBeyondRepair`,`description`) VALUES ('" + textBox1.Text + "'," + o + ",1,0,0,0,0,0,0,0,'" + textBox2.Text + "');", conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Successfully added to database.", "Successful. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
                                    this.Close();
                                    (System.Windows.Forms.Application.OpenForms["EquipmentUI"] as EquipmentUI).refreshni();
                                 
                                }
                            }
                        }
                    }
                }


            }
            conn.Close();
        }
    

        private void Form2_Load(object sender, EventArgs e)
        {

        }

   
    }
}
