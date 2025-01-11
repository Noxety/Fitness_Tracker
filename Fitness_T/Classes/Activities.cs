using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_T.Classes
{
    internal class Activities
    {
        private int id;
        private string activity_name;
        private string metric;
        private double mETs;
        private double minutes;

        public int ID { get { return id; } set { id = value; } }
        public string ActivityName { get { return activity_name; } set { activity_name = value; } }

        public string Metric { get { return metric; } set { metric = value; } }

        public double METs { get { return mETs; } set { mETs = value; } }

        public double Minutes { get { return minutes; } set { minutes = value; } }
    }
}
