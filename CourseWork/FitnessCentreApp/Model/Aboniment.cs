using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessCentreApp.Model
{
    class Aboniment
    {
        public int abonID { get; set; }
        public int groupcount { get; set; }
        public DateTime selldata { get; set; }
        public string name { get; set; }
        public double cost { get; set; }
        public double sale { get; set; }
        public bool pool { get; set; }
        public string description { get; set; }
        public int duration { get; set; }
            
    }
}
