using duan1.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
   public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu>GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.name,bi.count,f.gia ,f.gia*bi.count as totalPrice FROM dbo.TTHOADON AS bi JOIN dbo.HOADON AS b ON bi.idtthd = b.id   JOIN dbo.TPHONG AS f ON bi.idphong = f.id   and b.status=0  WHERE b.idhd =   "+id;
            DataTable data = DataProvider.Instance.ExeCuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
