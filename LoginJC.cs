using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinFormsApp15
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Get username and password from the txtboxes remove extra space
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //Check if username password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and paddword");
                return; //Stop the login proxess/progress
            }
            //Call db connection string
            DBConnect db= new DBConnect();

            try
            {
                db.Open();//Open Data Base Connection
                //SQL query to count matching username and password
                string query = "SELECT COUNT(*) FROM users WHERE " +
                    "username=@username AND password=@password";

                //Create my SQL Command
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                //Execute query and get result
                int count= Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    //if 1 record found, login sucessful
                    MessageBox.Show("Login Sucessful!");
                    //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    //No match found
                    MessageBox.Show("Invalid Username or Password");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();//clsoe database connection
            }
            }   


           
            }


          



        }
  
