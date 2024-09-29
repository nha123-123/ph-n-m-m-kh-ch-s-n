using duan1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
    public class BillInfoDao
    {
        private static BillInfoDao instance;

        public static BillInfoDao Instance { 
            get { if (instance == null) instance = new BillInfoDao(); return BillInfoDao.instance; }
           private set { BillInfoDao.instance = value; }
        }
        private BillInfoDao()
        {

        }
        public List<BillInfo>GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExeCuteQuery("select*from dbo.TTHOADON where idtthd = "+id);
            foreach (DataRow item in data.Rows) {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
                    
                    
                    }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill,int idPhong,int count)
        {
            DataProvider.Instance.ExeCuteNonQuery("exec USB_InsertBillInfo @idBill  , @idPhong , @count ", new object[] { idBill,idPhong,count });
        }
        public void DeleteBillInfoByPhongID(int id)
        {
            DataProvider.Instance.ExeCuteQuery("delete dbo.TTHOADON where idphong = "+id);
        }
        internal object GetListBillInfo()
        {
            throw new NotImplementedException();
        }
    }
}
