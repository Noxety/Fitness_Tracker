using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_T.Classes
{
    public class User
    {
        private int id;
        private string name;
        private string password;
        private double goal;
        private double weight;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public double Goal { get { return goal; } set { goal = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public  string HashPassword(string password)// Password hash function
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            else
            {
                using (SHA256  sha256 = SHA256.Create())
                {
                    byte[]bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha256.ComputeHash(bytes);
                    StringBuilder sb = new StringBuilder();
                    foreach(byte b in hash)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
        }
        public  bool ValidatePassword(string enteredpass , string password)//validate Hashed Password
        {
            string hashenteredPass = HashPassword(enteredpass);
            return password == hashenteredPass;
        }
    }
}
