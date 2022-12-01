using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class BillDAO
    {
        DataProvider dataProvider;
        string query;

        public BillDAO()
        {
            dataProvider = new DataProvider();
        }

        public int Insert(BillDTO bill, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Add] @employee_id , @customer_phone , @discount";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill.employee_id, bill.customer_phone, bill.discount });
        }

        public int Update(BillDTO bill, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Update] @bill_id , @name";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill.bill_id, bill.employee_id });
        }

        public int Delete(int billId, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Delete] @bill_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { billId });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Bill_GetAll]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public int GetNewestBillId(ref string errorMessage)
        {
            query = "SELECT [dbo].[func_Bill_GetNewestBillId] ()";
            return (int)(dataProvider.ExecuteScalar(query, ref errorMessage));
        }

        public int RoundTotal(int bill_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_RoundTotal] @bill_id";
            return dataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill_id });
        }
        public DataTable StatisticByMontḥ(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[func_Statistic_Sale_ByMonth]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
        public DataTable StatisticByYear(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[func_Statistic_Sale_ByYear]()";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
        public DataTable ViewBill(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[view_BILL_BILLINFO]";
            return dataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
