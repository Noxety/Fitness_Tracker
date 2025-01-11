using Fitness_T.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_T
{
    public partial class SignUp : Form
    {
        User user = new User();
        DAO dao = new DAO();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e) // Validate of Checking User Info , Register User & Go back to Login 
        {
            if (txt_name.Text == "" || txt_name.Text == null || txt_pass.Text == "" || txt_pass.Text == null || txt_con_pass.Text == "" || txt_con_pass.Text == null)
            {
                MessageBox.Show("Please Fill The Data Information!");
                return;
            }
            else
            {

                if (txt_con_pass.Text == txt_pass.Text)
                {
                    if (txt_pass.TextLength == 12)
                    {
                        user = dao.Finduser(txt_name.Text);
                        if (user == null)
                        {
                            double goal = 0;
                            double weight = 0;
                            
                    
                            dao.InsertUser(txt_name.Text, txt_pass.Text,goal,weight);
                            MessageBox.Show("Your account have been Created");

                           
                            Login login = new Login();
                            this.Hide();
                            login.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("This Username have already account !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Password must contain 1 Capital Letter,1 Small Letter & Must be 12 character!!!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Your Confirmed password is wrong!");
                    return;
                }
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) // Password Show & Hide Function
        {
            txt_pass.PasswordChar = check_pass.Checked ? '\0' : '*';
            txt_con_pass.PasswordChar = check_con.Checked ? '\0' : '*';

            if (check_pass.Checked)
            {
                check_pass.Text = "Hide";
            }
            else
            {
                check_pass.Text = "Show";
            }

            if (check_con.Checked)
            {
                check_con.Text = "Hide";
            }
            else
            {
                check_con.Text = "Show";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// Return Back To Login 
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }

}
