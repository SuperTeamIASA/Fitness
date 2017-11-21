using System;
namespace FitnessCentreApp.Model
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }   
        public string empLastName { get; set; }  
        public DateTime empBdate { get; set; }
        public string empEmail { get; set; }
        public string empPhone { get; set; }
        public int postId { get; set; }
    }
}