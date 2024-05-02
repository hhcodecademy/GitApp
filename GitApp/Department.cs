using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
 
   
    internal class Department
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Department()
        {
            Doctors = new List<Doctor>();
            Employees = new List<Employee>();
        }
    }
}
