using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    internal class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            string fullName = $"Id: {this.Id} Name: {this.Name}";
            return fullName;
        }
    }
}
