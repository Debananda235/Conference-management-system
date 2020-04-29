using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Database_Project
{
    public partial class LoginForm : Form
    {
        string username = "Admin";
        string Email = "Admin@gmail.com";
        string password = "12345";


        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection con;
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string role = this.comboBox1.SelectedItem.ToString();
            switch (role)
            {
                case "Admin":
                    {
                        if ((textBox1.Text == this.Email || textBox1.Text == this.username) && textBox2.Text == this.password)
                        {
                            Admin f3 = new Admin();
                            f3.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or password incorrect");
                        }
                        break;
                    }
                case "Participant":
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "select password from Participant where email=:email";
                        cmd.Parameters.Add("email", textBox1.Text.ToString());

                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if ((textBox2.Text) == dr[0].ToString())
                            {
                                Reg_log.logged_email= textBox1.Text;
                                ParticipantForm f8 = new ParticipantForm();
                                f8.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password ");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Email");
                        }
                        dr.Close();

                        break;
                    }
                case "Authors":
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "select password from Authors where username =:name";
                        cmd.Parameters.Add("name", textBox1.Text.ToString());
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (textBox2.Text == dr[0].ToString())
                            {
                                AuthorsForm f9 = new AuthorsForm();
                                f9.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password ");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid UserName");
                        }
                        dr.Close();
                        break;
                    }


                case "Reviewer":
                    {

                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "select password from REVIEWERS where Email=:email";
                        cmd.Parameters.Add("email", textBox1.Text.ToString());
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (textBox2.Text == dr[0].ToString())
                            {
                                ReviewersForm f10 = new ReviewersForm();
                                f10.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password ");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Email");
                        }
                        dr.Close();
                        break;
                    }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Reviewer");
            comboBox1.Items.Add("Authors");
            comboBox1.Items.Add("Participant");
        }
    }
}
