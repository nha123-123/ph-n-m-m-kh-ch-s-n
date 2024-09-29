using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DTO
{
    public class Phong
    {
        public Phong(int id, string name, int categoryID,float price ) { 
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }
        public Phong(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["iddm"];
            this.Price = (float)Convert.ToDouble(row["gia"].ToString());

        }
        private int iD;
        private string name;
        private float price;
        private int categoryID;

        public int ID {
            get {  return iD; }
            set { iD = value; }
        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public float Price {
            get { return price; }
            set { price = value; }
        }
        public int CategoryID { 
            get { return categoryID; }
            set { categoryID = value; }
        }
    }
}
