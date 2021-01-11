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
    public class PeriodRepository : IPeriodRepository
    {
        public List<Period> GetPeriods()
        {
            List<Period> listPeriods = new List<Period>();
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("SELECT * FROM Periods");

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Period p = new Period();

                    p.Id = sqlDataReader.GetInt32(0);
                    p.Start_time = sqlDataReader.GetTimeSpan(1);
                    p.End_time = sqlDataReader.GetTimeSpan(2);
                    listPeriods.Add(p);
                }
            }
            return listPeriods;
        }

        //*************************************************************************************************
        public int InsertPeriod(Period p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = string.Format("INSERT INTO Periods VALUES ({0},'{1}','{2}')", p.Id, p.Start_time, p.End_time);
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }

        }
        //*************************************************************************************************
        public int UpdatePeriod(Period p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Periods SET ID={0}, START_TIME='{1}', END_TIME='{2}'" + "WHERE ID={3}", p.Id, p.Start_time, p.End_time, p.Id);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
