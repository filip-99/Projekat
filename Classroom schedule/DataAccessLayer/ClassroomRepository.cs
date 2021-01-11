using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClassroomRepository : IClassroomRepository
    {
        public List<Classroom> GetClassrooms()
        {
            List<Classroom> listClassrooms = new List<Classroom>();
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("SELECT * FROM Classrooms");

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Classroom c = new Classroom();

                    c.Number = sqlDataReader.GetInt32(0);
                    c.Capacity = sqlDataReader.GetInt32(1);
                    listClassrooms.Add(c);
                }
            }
            return listClassrooms;
        }

        //*************************************************************************************************
        public int InsertClassroom(Classroom c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = string.Format("INSERT INTO Classrooms VALUES ({0},{1})", c.Number, c.Capacity);
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }

        }
        //*************************************************************************************************
        public int UpdateClassroom(Classroom c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Classrooms SET NUMBER={0}, CAPACITY={1}" + "WHERE NUMBER={2}", c.Number, c.Capacity, c.Number);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }

    }
}
