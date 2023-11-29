using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA1_College
{
    public class Student : Person
    {
        public int StudentNumber { get; set; }

        public Student(string name, string address, string county, int age, string email, string phone, string gender, string course, string module, int studentNumber)
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
            StudentNumber = studentNumber;
        }

        public override void AddPerson()
        {
            throw new NotImplementedException();
        }
    }
}
