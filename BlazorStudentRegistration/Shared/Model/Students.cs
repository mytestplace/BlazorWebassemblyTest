using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudentRegistration.Shared.Model
{
    public class Students
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name  { get; set; }
        public string DateOfBirth { get; set; }
        public string  Class_ { get; set; }
        public int  MobileNumber { get; set; }
        public string  Email { get; set; }
        public bool IsActive { get; set; }
        
    }
}
