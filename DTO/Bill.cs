using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DTO
{
    public class Bill
    {
        private int discount;
        public int Discount {
            get {  return discount; } 
            set { discount = value; }

    }
        public Bill(int id, DateTime? dateCheckin,DateTime? dateCheckOut, int status, int discount = 0) {
            this.iD = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;   
     
        }

        public Bill(DataRow row) {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["NgayV"];
            var dateCheckOutTemp = row["NgayR"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
               
            this.Status = (int)row["status"];
            this.Discount = row["discount"] != DBNull.Value ? Convert.ToInt32(row["discount"]) : 0;




        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { 
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn { 
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int ID;
        public int iD { 
            get { return ID;}
            set { ID = value; }
        }
        private int Status;
        public int status
        {
            get { return Status; }
            set { Status = value; }
        }

       
    }
}
