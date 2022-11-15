using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class PositionDAO
    {
        DataProvider dataProvider;
        string query;

        public PositionDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(PositionDTO position, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Position_Add] @name , @salary";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { position.name, position.salary });
        }

        public int Update(PositionDTO position, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Position_Update] @position_id , @name , @salary";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { position.position_id, position.name, position.salary });
        }

        public int Delete(int position_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Position_Delete] @position_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { position_id });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Position_GetAll]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
