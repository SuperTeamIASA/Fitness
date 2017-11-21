using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreApp.Model
{
    class Lessons
    {
        public int lessonid { get; set;}
        public string description { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public decimal groupcost { get; set; }
        public decimal indivcost { get; set; }
    }
}
