using duan1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
   
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get{ if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
          private  set { instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from DMPHONG";
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
                return list;
        }
        public bool InsertDMPhong(string name)
        {
            string query = string.Format("INSERT dbo.DMPHONG (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDMPhong( string name, int id)
        {
            // Sửa lại câu truy vấn với các dấu nháy đơn chính xác
            string query = string.Format("UPDATE dbo.DMPHONG SET name = N'{0}' WHERE id = {1}", name, id);

            // Thực thi câu lệnh
            int result = DataProvider.Instance.ExeCuteNonQuery(query);

            // Trả về kết quả
            return result > 0;
        }
        public bool DeleteDMPhong(int idDMPhong)
        {
            // Xóa các bản ghi trong TPHONG tham chiếu đến DMPHONG
            string deleteTPHONGQuery = string.Format("DELETE FROM TPHONG WHERE iddm = {0}", idDMPhong);
            DataProvider.Instance.ExeCuteNonQuery(deleteTPHONGQuery);

            // Sau đó, xóa bản ghi trong DMPHONG
            string query = string.Format("DELETE FROM DMPHONG WHERE id = {0}", idDMPhong);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from DMPHONG where id = "+id;
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
               category = new Category(item);
                return category;
            }
            return category;
        }
       
    }
    
}
