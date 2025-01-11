using Fitness_T.Classes;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_T
{
    public partial class Dashboard : Form
    {
        DAO dao = new DAO();
        User user = new User();
        Activities activities = new Activities();
        double totalCal = 0.0;
        List<Record> records = new List<Record>();
        double result = 0.0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void fillChart()//Fill Data to Chart
        {
            int c = 1;
            if (records == null)
            {
                recordChart.Visible = false;
                label_text.Text = " ";
                
            }
            else
            {
                foreach (Record r in records)
                {
                    recordChart.Series["Records"].Points.AddXY($"Records {c}", r.Records);
                    c++;

                }
            }
            
        }

        public Dashboard(User u) //Initialize Dashboard with user data
        {
            InitializeComponent();

          
           
            gbdata.Visible = false;
            user = u;
            lbl_name.Text = lbl_name.Text + u.Name;
            lbl_weight.Text = lbl_weight.Text + Convert.ToInt32(u.Weight) + " kg";
            lbl_goal.Text = lbl_goal.Text + u.Goal + " Calories";
            records = dao.Get_Record(u.Id);
            if(records == null )
            {
                lbl_total.Text = "There is no Records Yet !";
            }
            else
            {
                for (int i = 0; i < records.Count; i++)
                {
                    totalCal += records[i].Records;
                }
                lbl_total.Text = lbl_total.Text + Convert.ToInt32(totalCal) + " Calories";
               
            }
            if (totalCal < user.Goal)
            {
                label_text.Text = "Your goal is Still not achieved";
            }
            if (u.Weight == 0 || u.Goal == 0)
            {
                gbdata.Visible = true;
                lbl_alert.Visible = true;
            }
            fillChart();
            
        }

        private void btn_submit_Click(object sender, EventArgs e)//Add Record Data To Database & Refresh Dashboard
        {
            
            string matric;
            if (radio_1.Checked)
            {
                matric = "slow";
            }
            else if (radio_2.Checked)
            {
                matric = "normal";
            }
            else
            {
                matric = "fast";
            }

            DialogResult dialogResult = MessageBox.Show("You Want to Record Data ?", "Alert", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (list.Text == "Rope Jumping")
                {
                    activities = dao.FindActivity("jump", matric);
                }
                else
                {
                    activities = dao.FindActivity(list.Text, matric);
                }
                    result = (activities.Minutes * (activities.METs * 3.5 * user.Weight)) / 200;
                    dao.InsertUserRecords(result, user.Id);
                
                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.ShowDialog();
                
               
            }
            else if (dialogResult == DialogResult.No)
            {

                return;

            }
        }

        private void selected_changed(object sender, EventArgs e)//Select And Change Activities 
        {
            if (list.Text == "Bicycling")
            {
                radio_1.Text = "light effort , slow (10-11.9mph)";
                radio_2.Text = "moderate effort , normal (12-13.9mph)";
                radio_3.Text = "vigorous effort , fast (14-15.9,mph)";
            }
            else if (list.Text == "Running")
            {
                radio_1.Text = "slow(5mph)";
                radio_2.Text = "moderate(8mph)";
                radio_3.Text = "fast(12mph)";
            }
            else if (list.Text == "Aerobic")
            {
                radio_1.Text = "step with 4-inch step , 1 lap";
                radio_2.Text = "step with 6 - 8 inch step , 1 lap";
                radio_3.Text = "step with 10 - 12 inch step , 1 lap";
            }
            else if (list.Text == "Swimming")
            {
                radio_1.Text = "light effort , 1 lap";
                radio_2.Text = "moderate effort , 1 lap";
                radio_3.Text = "vigorous effort , 1 lap";
            }
            else if (list.Text == "Rope Jumping")
            {
                radio_1.Text = "slow pace, < 100 skips/min";
                radio_2.Text = "moderate pace, 100-120 skips/min";
                radio_3.Text = "fast pace, 120-160 skips/min";
            }
            else if (list.Text == "Walking")
            {
                radio_1.Text = "very slow , less than 2.0 mph";
                radio_2.Text = "slow , 2mph";
                radio_3.Text = "normal  2.8mph to 3.2 mph";
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)//Update Weight And Height data
        {
            if (txt_goal.Text == "" || txt_goal.Text == null || txt_weight.Text == "" || txt_weight.Text == null)
            {

                MessageBox.Show("Please Fill the data Information!!"); return;
            }
            else
            {
                double weight = Convert.ToDouble(txt_weight.Text);
                double goal = Convert.ToDouble(txt_goal.Text);
               
                if (Cmb_1.Text == "lb")
                {
                    weight = Convert.ToDouble(txt_weight.Text) * 0.45359237;

                    if(dao.Updatedata(weight, goal, user.Name))
                    {
                        user = dao.Finduser(user.Name);
                        gbdata.Visible = false;
                        lbl_goal.Text = "Goal - ";
                        lbl_weight.Text = "Weight - ";
                        lbl_goal.Text = lbl_goal.Text + user.Goal + " Calories";
                        lbl_weight.Text = lbl_weight.Text + Convert.ToInt32(user.Weight) + " kg";
                        if (totalCal < user.Goal)
                        {
                            label_text.Text = "Your goal is Still not Achieved";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserted Error");
                    }

                }

                else
                {

                    if(dao.Updatedata(weight, goal, user.Name))
                    {
                        user = dao.Finduser(user.Name);
                        gbdata.Visible = false;
                        lbl_goal.Text = "Goal - ";
                        lbl_weight.Text = "Weight - ";
                        lbl_goal.Text = lbl_goal.Text + user.Goal + " Calories";
                        lbl_weight.Text = lbl_weight.Text + user.Weight + " kg";
                        if (totalCal < user.Goal)
                        {
                            label_text.Text = "Your goal is Still not Achieved";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserted Error");
                    }
                   
                }

            }
        }

        private void btn_change_data_Click(object sender, EventArgs e) // Show Weight And Height group Box
        {
            gbdata.Visible = true;
        }

        private void btn_log_out_Click(object sender, EventArgs e)//Logout button to go back Login 
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
