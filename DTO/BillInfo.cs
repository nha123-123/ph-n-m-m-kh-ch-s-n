using System.Data;

namespace duan1.DTO
{
    public class BillInfo
    {
        // Constructor với các giá trị truyền vào
        public BillInfo(int id, int billID, int phongID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.PhongID = phongID;
            this.Count = count;
        }

        // Constructor khởi tạo từ một DataRow
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idtthd"];
            this.PhongID = (int)row["idphong"];
            this.Count = (int)row["count"];
        }

        // Thuộc tính Count
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        // Thuộc tính PhongID
        private int phongID;
        public int PhongID
        {
            get { return phongID; }
            set { phongID = value; }
        }

        // Thuộc tính BillID
        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        // Thuộc tính ID
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
