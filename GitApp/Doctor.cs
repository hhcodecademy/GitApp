﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    internal class Doctor
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Diagnostic> Diagnostics { get; set; }

    }
}
