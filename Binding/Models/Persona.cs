using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.Models
{
    internal class Persona
    {
        public string name{ get; set; }
        public string lastname1 { get; set; }
        public string lastname2 { get; set; }
        public Persona(string name, string lastname1, string lastname2) 
        {
            this.name = name;
            this.lastname1 = lastname1;
            this.lastname2 = lastname2;
        }
    }
}
