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
    public partial class NewStudents : Form
    {
        public NewStudents()
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
            student.AddPerson();

            MessageBox.Show("Data Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFn.Clear();
            txtSn.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            txtStuNo.Clear();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            //Current Year - Birth Year
            int age = DateTime.Today.Year - dtpDOB.Value.Year;

            if (DateTime.Today.Month < dtpDOB.Value.Month) age--;
            else if ((DateTime.Today.Month >= dtpDOB.Value.Month) && (DateTime.Today.Day < dtpDOB.Value.Day)) age--;

            lblAgeDisplay.Text = age.ToString();
        }
    }
}
