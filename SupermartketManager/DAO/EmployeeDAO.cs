using SupermartketManager.DTO;
using SupermartketManager.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class EmployeeDAO
    {
        DataProvider dataProvider;
        string query;

        public EmployeeDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(EmployeeDTO employee, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Employee_Add] @name , @phone , @position_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { employee.name, employee.phone, employee.position_id });
        }

        public int Update(EmployeeDTO employee, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Employee_Update] @employee_id , @name , @phone , @position_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { employee.employee_id, employee.name, employee.phone, employee.position_id });
        }

        public int Delete(int employee_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Employee_Delete] @employee_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { employee_id });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Employee_GetAll]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
