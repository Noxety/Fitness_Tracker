using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_T.Classes;
namespace Fitness_T
{
    public partial class Login : Form
    {
        User user = new User();
        DAO dao = new DAO();
        private int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e) // Validate User data & Submit Click Button To Go Dashboard 
        {
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Enter your Account Detail !!!");
                return;
            }
            else
            {
                user = dao.Finduser(txt_name.Text);
                
                if(user != null )
                {
                    if (user.ValidatePassword(txt_pass.Text,user.Password)==false)
                    {

                        MessageBox.Show("Your password is wrong Try Again!!");
                        if (count == 2)
                        {
                            MessageBox.Show("Your Account is Locked . Please Restart the Application");
                        }
                        else
                        {
                            count++;
                            return;

                        }
                    }
                    else
                    {
                        if (count == 2)
                        {
                            MessageBox.Show("Your Account is Locked");
                        }
                        else
                        {
                            Dashboard dashboard = new Dashboard(user);
                          
                            this.Hide();
                            dashboard.ShowDialog();
                            
                        }
                    }
                }
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)    // Password Show & Hide Function
        {
            txt_pass.PasswordChar = check_hide.Checked ? '\0' : '*';

            if (check_hide.Checked)
            {
                check_hide.Text = "Hide";
            }
            else
            {
                check_hide.Text = "Show";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Click Link Button to Go SignUp  
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
        }
    }
}
