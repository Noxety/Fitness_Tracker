using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_T.Classes
{
    internal class DAO
    {
        public static string connectionString = "server=localhost;database=fitness;UID=root;password=root"; // Database Connetion
        MySqlConnection conn;
        public User Finduser(string name) // Finding User from Database
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "select * from user where name=@name;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                MySqlDataReader res = cmd.ExecuteReader();

                if (res.Read() == false)
                {
                    return null;
                }
                else
                {
                    res.Read();
                    User user = new User();
                    user.Name = res.GetString("name");
                    user.Password = res.GetString("password");
                    user.Id = res.GetInt32("id");
                    user.Goal = res.GetDouble("goal");
                    user.Weight = res.GetDouble("weight");

                    conn.Close();

                    return user;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }
        public bool InsertUser(string name, string pass , double goal , double weight) // Insert User into Database
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                string regex = "^(?=.*[a-z])(?=.*[A-Z]).{12}$";
                Regex re = new Regex(regex);
                if (!re.IsMatch(pass))
                {
                    MessageBox.Show("Your Password must contain 1 Capital Letter,1 Small Letter & Must be 12 character!!!");
                    return false;

                }
                else
                {
                    User user = new User();
                    string hashedPass = user.HashPassword(pass);
                    conn.Open();
                    string query = "insert into user (name,password,goal,weight) values (@name,@pass,@goal,@weight);";
                    MySqlCommand cms = new MySqlCommand(query, conn);
                    cms.Parameters.AddWithValue("@name", name);
                    cms.Parameters.AddWithValue("@pass", hashedPass);
                    cms.Parameters.AddWithValue("@goal", goal);
                    cms.Parameters.AddWithValue("@weight", weight);

                    MySqlDataReader reader = cms.ExecuteReader();

                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error!! {ex}");
                return false;
            }
        }
        public bool Updatedata(double weight, double goal, string name) // Update User data of Weigth and Height
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = $"update user set weight=@weight,goal=@goal where name=@name;";
                MySqlCommand cms = new MySqlCommand(query, conn);
                cms.Parameters.AddWithValue("@name", name);
                cms.Parameters.AddWithValue("@weight", weight);
                cms.Parameters.AddWithValue("@goal", goal);
                MySqlDataReader reader = cms.ExecuteReader();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"!! {ex}");
                return false;
            }
        }
        public Activities FindActivity(string name, string metric) //Finding Activities from database
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "select * from activity where activity_name=@name and metric=@metric;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@metric", metric);
                MySqlDataReader res = cmd.ExecuteReader();

                if (res.Read() == false)
                {
                    return null;
                }
                else
                {
                    Activities activity = new Activities();
                    res.Read();
                    activity.ID = res.GetInt32("id");
                    activity.ActivityName = res.GetString("activity_name");
                    activity.Metric = res.GetString("metric");
                    activity.METs = res.GetDouble("METs");
                    activity.Minutes = res.GetDouble("minutes");
                    conn.Close();
                    return activity;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }
        public bool InsertUserRecords(double record, int id) // Insert User's Records into Database
        {
            conn = new MySqlConnection(connectionString);
            try
            {

                conn.Open();
                string query = "insert into records (records,user_id) values (@records,@user_id);";
                MySqlCommand cms = new MySqlCommand(query, conn);
                cms.Parameters.AddWithValue("@records", record);
                cms.Parameters.AddWithValue("@user_id", id);

                MySqlDataReader reader = cms.ExecuteReader();

                return true;



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error!! {ex}");
                return false;
            }
        }
        public List<Record> Get_Record(int id) //Get Record from database
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                string query = "select * from records where user_id=@user_id;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", id);

                MySqlDataReader res = cmd.ExecuteReader();


                List<Record> recordsList = new List<Record>();
                while (res.Read())
                {
                    Record records = new Record();
                    records.Records = res.GetDouble("records");
                    recordsList.Add(records);
                }
                conn.Close();
                if (recordsList.Count == 0) { return null; }
                return recordsList;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }
    }
}
