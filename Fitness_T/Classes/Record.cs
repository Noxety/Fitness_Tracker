using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_T.Classes
{
    internal class Record
    {


        private int id;
        private double records;
        private int user_id;

        public int ID { get { return id; } set { id = value; } }
        public int User_id { get { return user_id; } set { user_id = value; } }

        public double Records {  get {  return records; } set { records = value; } }
    }
}
