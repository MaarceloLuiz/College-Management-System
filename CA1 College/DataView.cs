using Bank___Week_5_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CA1_College
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;

        private void DataView_Load(object sender, EventArgs e)
        {
            string proc = "ProcGetAllStudent";
            LoadData(proc, DGVStu);

            string proc2 = "ProcGetAllLecturer";
            LoadData(proc2, DGVLec);

            cboShowGender.DataSource = Enum.GetValues(typeof(Gender));
            cboShowCourse.DataSource = Enum.GetValues(typeof(Course));
            cboShowGender.DataSource = Enum.GetValues(typeof(Gender));
            cboShowModule.DataSource = Enum.GetValues(typeof(AllModules));
        }

        void LoadData(string proc, DataGridView dgv)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText= proc;
            cmd.CommandType= CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;

            dao.CloseCon();
        }

        void LoadDataWithParam(string proc, DataGridView dgv, string paramether, object value)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = proc;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(paramether, value);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgv.DataSource = dt;

            dao.CloseCon();
        }

        private void cboShowCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboShowCourse.SelectedIndex.Equals(0)) cboShowModule.DataSource = Enum.GetValues(typeof(ModuleCS));
            //if (cboShowCourse.SelectedIndex.Equals(1)) cboShowModule.DataSource = Enum.GetValues(typeof(ModulePSY));
            //if (cboShowCourse.SelectedIndex.Equals(2)) cboShowModule.DataSource = Enum.GetValues(typeof(ModuleHis));
        }

        private void btnShowAllLecturers_Click(object sender, EventArgs e)
        {
            string proc = "ProcGetAllLecturer";
            LoadData(proc, DGVLec);
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            string proc = "ProcGetAllStudent";
            LoadData(proc, DGVStu);
        }

        private void btnShowAbove_Click(object sender, EventArgs e)
        {
            //showing all students above the Age we choose
            string proc = "ProcAllAboveStu";
            string param = "@age";
            int age = int.Parse(txtShowAge.Text);

            LoadDataWithParam(proc, DGVStu, param, age);
        }

        private void btnShowGender_Click(object sender, EventArgs e)
        {
            //showing all lecturers from this gender
            string proc = "ProcGenderLec";
            string param = "@gender";
            string gen = cboShowGender.SelectedItem.ToString();

            LoadDataWithParam(proc, DGVLec, param, gen);
        }

        private void btnShowCourse_Click(object sender, EventArgs e)
        {
            string proc = "ProcCourseStu";
            string param = "@course";
            string course = cboShowCourse.SelectedItem.ToString();

            LoadDataWithParam(proc, DGVStu, param, course);
        }

        private void btnShowModule_Click(object sender, EventArgs e)
        {
            string proc = "ProcModuleLec";
            string param = "@courseModule";
            string module = cboShowModule.SelectedItem.ToString();

            LoadDataWithParam(proc, DGVLec, param, module);
        }
    }
}
