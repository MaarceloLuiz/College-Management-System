using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_College
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public string Module { get; set; }

        public abstract void AddPerson();

    }
}
