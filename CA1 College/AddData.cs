using Bank___Week_5_class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CA1_College
{
    internal class AddData : DAO
    {
        public void AddNewLecturer(Lecturer lecturer)
        {
            SqlCommand cmd = OpenCon().CreateCommand();

            //collecting the information we inserted in the StoredProcedure
            cmd.CommandText = "ProcAddLecturer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", lecturer.Name);
            cmd.Parameters.AddWithValue("@Address", lecturer.Address);
            cmd.Parameters.AddWithValue("@County", lecturer.County);
            cmd.Parameters.AddWithValue("@Age", lecturer.Age);
            cmd.Parameters.AddWithValue("@Email", lecturer.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", lecturer.Phone);
            cmd.Parameters.AddWithValue("@Gender", lecturer.Gender);
            cmd.Parameters.AddWithValue("@Course", lecturer.Course);
            cmd.Parameters.AddWithValue("@CourseModule", lecturer.Module);
            cmd.Parameters.AddWithValue("@Pay", lecturer.Pay);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNewStudent(Student student)
        {
            SqlCommand cmd = OpenCon().CreateCommand();

            //collecting the information we inserted in the StoredProcedure
            cmd.CommandText = "ProcAddStudent";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Address", student.Address);
            cmd.Parameters.AddWithValue("@County", student.County);
            cmd.Parameters.AddWithValue("@Age", student.Age);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", student.Phone);
            cmd.Parameters.AddWithValue("@Gender", student.Gender);
            cmd.Parameters.AddWithValue("@Course", student.Course);
            cmd.Parameters.AddWithValue("@CourseModule", student.Module);
            cmd.Parameters.AddWithValue("@StudentNo", student.StudentNumber);

            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}