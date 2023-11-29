using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_College
{
    public class Lecturer : Person
    {
        public double Pay { get; set; }

        public Lecturer(string name, string address, string county, int age, string email, string phone, string gender, string course, string module, double pay)
        {
            Name = name;
            Address = address;
            County = county;
            Age = age;
            Email = email;
            Phone = phone;
            Gender = gender;
            Course = course;
            Module = module;
            Pay = pay;
        }

        public override void AddPerson()
        {
            throw new NotImplementedException();
        }
    }
}
