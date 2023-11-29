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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        Student student;

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex.Equals(0)) cboModule.DataSource = Enum.GetValues(typeof(ModuleCS));
            if (cboCourse.SelectedIndex.Equals(1)) cboModule.DataSource = Enum.GetValues(typeof(ModulePSY));
            if (cboCourse.SelectedIndex.Equals(2)) cboModule.DataSource = Enum.GetValues(typeof(ModuleHis));
        }

        private void Students_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCourse.DataSource = Enum.GetValues(typeof(Course));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtFn.Text + " " + txtSn.Text;
            string address = txtAddress.Text;
            int age = int.Parse(lblAgeDisplay.Text);
            string county = cboCounty.SelectedItem.ToString();
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;

            string ge = "Male";
            if (rbFemale.Checked) ge = "Female";

            string course = cboCourse.SelectedItem.ToString();
            string module = cboModule.SelectedItem.ToString();
            int studentNumber = int.Parse(txtStuNo.Text);

            student = new Student(name, address, county, age, email, phoneNo, ge, course, module, studentNumber);
        }
    }
}
