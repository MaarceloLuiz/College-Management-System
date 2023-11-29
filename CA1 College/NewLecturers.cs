using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA1_College
{
    public partial class NewLecturers : Form
    {
        public NewLecturers()
        {
            InitializeComponent();
        }

        Lecturer lecturer;

        private void Lecturers_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCourse.DataSource = Enum.GetValues(typeof(Course));
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex.Equals(0)) cboModule.DataSource = Enum.GetValues(typeof(ModuleCS));
            if (cboCourse.SelectedIndex.Equals(1)) cboModule.DataSource = Enum.GetValues(typeof(ModulePSY));
            if (cboCourse.SelectedIndex.Equals(2)) cboModule.DataSource = Enum.GetValues(typeof(ModuleHis));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
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
            decimal pay = decimal.Parse(txtPay.Text);

            lecturer = new Lecturer(name, address, county, age, email, phoneNo, ge, course, module, pay);
            lecturer.AddPerson();

            MessageBox.Show("Data Added", "Add Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFn.Clear();
            txtSn.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            txtPay.Clear();
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
