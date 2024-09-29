using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DTO
{
    public class Category
    {


        public Category(int id, string name)
        {
            this.Name = name;
            this.ID = id;

        }
        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        private string name;
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

}
