using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class DataProvider
    {
        private string connectionString;
        private SqlConnection connection;

        public DataProvider()
        {
            connectionString = @"Data Source=dihuynh18\SQLEXPRESS01;Initial Catalog=SupermarketManagement;Integrated Security=True";
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query, ref string errorMessage, object[] parameterValues = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, ref string errorMessage, object[] parameterValues = null)
        {
            int rowsAffected = 0;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return rowsAffected;
        }

        public object ExecuteScalar(string query, ref string errorMessage, object[] parameterValues = null)
        {
            object data = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return data;
        }
    }
}
