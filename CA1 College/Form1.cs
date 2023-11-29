using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA1_College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewLecturers_Click(object sender, EventArgs e)
        {
            Lecturers lec = new Lecturers();
            lec.ShowDialog();
        }

        private void btnNewStudents_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            st.ShowDialog();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
