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
    public class SchedulingRepository : ISchedulingRepository
    {
        public List<Scheduling> GetSchedulings()
        {
            List<Scheduling> listSchedulings = new List<Scheduling>();
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("SELECT * FROM Scheduling");

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Scheduling s = new Scheduling();

                    s.Day = sqlDataReader.GetInt32(0);
                    s.Period_id = sqlDataReader.GetInt32(1);
                    s.Classroom_number = sqlDataReader.GetInt32(2);
                    s.Occupied = sqlDataReader.GetBoolean(3);
                    s.Duty_person = sqlDataReader.GetString(4);
                    listSchedulings.Add(s);
                }
            }
            return listSchedulings;
        }
        //*************************************************************************************************
        public int InsertScheduling(Scheduling s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = string.Format("INSERT INTO Scheduling VALUES ({0},{1},{2},'{3}','{4}')", s.Day, s.Period_id, s.Classroom_number, s.Occupied, s.Duty_person);
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }

        }
        //*************************************************************************************************
        public int UpdateScheduling(Scheduling s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Scheduling SET DAY={0}, PERIOD_ID={1}, CLASSROOM_NUMBER={2}, OCCUPIED='{3}', DUTY_PERSON='{4}' " + "WHERE DAY={5} AND PERIOD_ID={6} AND CLASSROOM_NUMBER={7}", s.Day, s.Period_id, s.Classroom_number, s.Occupied, s.Duty_person, s.Day, s.Period_id, s.Classroom_number);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
        //*************************************************************************************************
        public int DeleteScheduling(Scheduling s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Scheduling WHERE DAY = {0} AND PERIOD_ID = {1} AND CLASSROOM_NUMBER = {2}", s.Day, s.Period_id, s.Classroom_number);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
