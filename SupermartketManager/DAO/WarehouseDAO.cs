using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class WarehouseDAO
    {
        DataProvider dataProvider;
        string query;

        public WarehouseDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(WarehouseDTO warehouse, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Warehouse_Add] @name , @address";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { warehouse.name, warehouse.address });
        }

        public int Update(WarehouseDTO warehouse, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Warehouse_Update] @warehouse_id , @name , @address";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { warehouse.warehouse_id, warehouse.name, warehouse.address });
        }

        public int Delete(int warehouseId, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Warehouse_Delete] @warehouse_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { warehouseId });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Warehouse_GetAll]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
