using duan1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }

        }
        private PhongDAO() { }
        public List<Phong> GetRoomByCategoryID(int id)
        {
            List<Phong> list = new List<Phong>();
            string query = "select * from TPHONG where iddm = " + id;
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);


            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }
            return list;
        }

        public List<Phong> GetListPhong()
        {
            List<Phong> list = new List<Phong>();
            string query = "Select * from TPHONG";
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }
            return list;
        }
        
        public bool InsertPhong(string name, int id, float price)
        {
            BillInfoDao.Instance.DeleteBillInfoByPhongID(id);
            string query = string.Format("INSERT dbo.TPHONG (name,iddm,gia) VALUES (N'{0}','{1}','{2}')", name, id, price);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePhong(int idPhong, string name, int id, float price)
        {
            // Sửa lại câu truy vấn với các dấu nháy đơn chính xác
            string query = string.Format("UPDATE dbo.TPHONG SET name = N'{0}', iddm = {1}, gia = {2} WHERE id = {3}", name, id, price, idPhong);

            // Thực thi câu lệnh
            int result = DataProvider.Instance.ExeCuteNonQuery(query);

            // Trả về kết quả
            return result > 0;
        }
        public bool DeletePhong(int idPhong)
        {
            BillInfoDao.Instance.DeleteBillInfoByPhongID(idPhong);

            string query = string.Format("delete TPHONG where id = {0} ", idPhong);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public List<Phong> SearchPhongByName(string name)
        {
            List<Phong> list = new List<Phong>();
            string query = string.Format("select * from dbo.TPHONG where dbo.fuConvertToUnsign1(name) like N'%'+dbo.fuConvertToUnsign1(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }
            return list;

        }
    }
}