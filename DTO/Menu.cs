using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DTO
{
    public class Menu
    {
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        private string phongName;

        public string PhongName {
            get { return phongName; }
            set { phongName = value; }
        }
        private float totalTien;
        public float TotalTien { 
            get { return totalTien;}
            set { totalTien = value;
            }
        }


        private float price;
        public float Price { 
            get { return price;}
            set { price = value; }
        }

       
      public Menu(string phongName,int count, float price, float totalTien = 0)
        {
            this.PhongName = phongName;
            this.Count = count;
            this.Price = price;
            this.TotalTien = totalTien;
        }
        public Menu(DataRow row)
        {
            this.PhongName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["gia"].ToString());
            this.TotalTien = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

    }

}
