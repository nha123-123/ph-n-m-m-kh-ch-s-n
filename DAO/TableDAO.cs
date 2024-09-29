using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Azure.Amqp.Serialization.SerializableType;
using duan1.DTO;
using DocumentFormat.OpenXml.Office2010.Excel;
using Table = duan1.DTO.Table;

namespace duan1.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
     

        public static TableDAO Instance {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
          private  set {  TableDAO.instance = value; }
        }

        public static int TableWidth = 60;
        public static int TableHeight =60;  






        private TableDAO() { }
        public void SwitchTable(int id1,int id2)
        {
            DataProvider.Instance.ExeCuteQuery(" USP_SwitchTable @idTable1 , @idTable2 ", new object[] {id1,id2});
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExeCuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows) 
            {
                
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Table> GetListPhongN()
        {
            List<Table> tablelist = new List<Table>();
            string query = "Select * from PHONG";
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }




        public bool InsertPhongN(string name, string status)
        {

            string query = string.Format("INSERT dbo.PHONG (name,status) VALUES (N'{0}',N'{1}')", name, status);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePhongN(int idPhong)
        {
            // Xóa các bản ghi trong HOADON tham chiếu đến phòng trước
            string deleteHoadonQuery = string.Format("DELETE FROM dbo.HOADON WHERE idhd = {0}", idPhong);
            DataProvider.Instance.ExeCuteNonQuery(deleteHoadonQuery);

            // Sau khi xóa các bản ghi liên quan, xóa phòng trong bảng PHONG
            string deletePhongQuery = string.Format("DELETE FROM dbo.PHONG WHERE id = {0}", idPhong);
            int result = DataProvider.Instance.ExeCuteNonQuery(deletePhongQuery);

            return result > 0;
        }

        public bool UpdatePhongN(int id, string name, string status)
        {
            // Câu truy vấn cập nhật thông tin phòng theo id
            string query = string.Format("UPDATE dbo.PHONG SET name = N'{0}', status = N'{1}' WHERE id = {2}", name, status, id);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }








    }
}
