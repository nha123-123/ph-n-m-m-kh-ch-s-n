using duan1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO()
        {
        }
        public int getUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExeCuteQuery("select * from dbo.HOADON where idhd = "+id+" and status = 0");
            if (data.Rows.Count > 0) { 
                Bill bill = new Bill(data.Rows[0]);
                return bill.iD;



            }
            return -1;
        }
        public void CheckOut(int id, int discount,float totalPrice)
        {
            string query = "UPDATE dbo.HOADON set NgayR=GETDATE(), status=1, " + "discount = "+discount+ ",totalPrice = "+totalPrice+" where id = "+id;
            DataProvider.Instance.ExeCuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExeCuteNonQuery("exec USP_InsertBill @idTable",new object[] {id});
        }
        public DataTable GetBillListByDate(DateTime checkIn , DateTime checkOut) {


            return DataProvider.Instance.ExeCuteQuery("exec USP_FetListBillByDate  @checkIn , @checkOut", new object[]{checkIn,checkOut});
        }
        public int GetMaxIDBill()
        {
            try
            {


                return (int)DataProvider.Instance.ExeCuteScalar("select max(id) from dbo.HOADON");
            }
            catch
            {
                return 1;
            }
            }

        internal object GetBillListByDate()
        {
            throw new NotImplementedException();
        }
    }
}
