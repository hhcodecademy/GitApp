using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    internal class Diagnostic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
