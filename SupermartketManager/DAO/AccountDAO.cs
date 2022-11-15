using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class AccountDAO
    {
        DataProvider dataProvider;
        string query;

        public AccountDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(AccountDTO account, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Add] @username , @password , @employee_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, account.ToArray());
        }

        public int Update(AccountDTO account, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Update] @username , @password";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, account.ToArray());
        }

        public int Delete(string username, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Delete] @username";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { username });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Account_GetAll]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
