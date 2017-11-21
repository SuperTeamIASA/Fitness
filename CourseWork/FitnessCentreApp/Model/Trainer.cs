using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreApp.Model
{
    class Trainer
    {
        public int trainerId { get; set; }
        public int empId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bdate { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string about { get; set; }
        public string photo { get; set; }
    }
}
