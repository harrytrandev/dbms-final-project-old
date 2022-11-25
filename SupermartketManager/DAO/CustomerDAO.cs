using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class CustomerDAO
    {
        DataProvider dataProvider;
        string query;

        public CustomerDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(CustomerDTO customer, ref string errorMessage)
        {
            query = "EXEC dbo.proc_Customer_Add @customer_phone , @name, @birthday , @gender";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { customer.customer_phone, customer.name, customer.birthday, customer.gender }); ;
        }

        public int Update(CustomerDTO customer, ref string errorMessage)
        {
            query = "EXEC dbo.proc_Customer_Update @customer_phone , @name, @birthday , @gender";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { customer.customer_phone, customer.name, customer.birthday, customer.gender });
        }

        public int Delete(string customer_phone, ref string errorMessage)
        {
            query = "EXEC dbo.proc_Customer_Delete @customer_phone";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { customer_phone });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM dbo.func_Customer_GetAll()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public DataTable FindByPhone(string phone, ref string errorMessage)
        {
            query = "SELECT * FROM dbo.func_Customer_FindByPhone( @phone )";
            return dataProvider.ExecuteQuery(query, ref errorMessage, new object[] { phone });
        }

        public int AccumulatePoints(string customer_phone, int bill_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Customer_AccumulatePoints] @customer_phone , @bill_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { customer_phone, bill_id });
        }
        public DataTable MaxSpending(int year, int month, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Customer_FindMaxSpending] @Year , @Month";
            return dataProvider.ExecuteQuery(query, ref errorMessage, new object[] { year, month });
        }
    }
}
