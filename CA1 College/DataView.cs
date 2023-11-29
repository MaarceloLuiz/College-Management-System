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
            string proc = "ProcGetAll";
            LoadData(proc);

            cboShowGender.DataSource = Enum.GetValues(typeof(Gender));
            cboShowCourse.DataSource = Enum.GetValues(typeof(Course));
        }

        void LoadData(string proc)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText= proc;
            cmd.CommandType= CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            DGVCollege.DataSource = dt;

            dao.CloseCon();
        }

        private void cboShowCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShowCourse.SelectedIndex.Equals(0)) cboShowModule.DataSource = Enum.GetValues(typeof(ModuleCS));
            if (cboShowCourse.SelectedIndex.Equals(1)) cboShowModule.DataSource = Enum.GetValues(typeof(ModulePSY));
            if (cboShowCourse.SelectedIndex.Equals(2)) cboShowModule.DataSource = Enum.GetValues(typeof(ModuleHis));
        }

        private void btnShowAllLecturers_Click(object sender, EventArgs e)
        {
            string proc = "ProcGetAllLecturer";
            LoadData(proc);
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            string proc = "ProcGetAllStudent";
            LoadData(proc);
        }
    }
}
