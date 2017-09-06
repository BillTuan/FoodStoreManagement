using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo (int iD, int billID, int foodID, int count)
        {
            this.ID = iD;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo (DataRow row)
        {
            this.ID = (int)row["iD"];
            this.BillID = (int)row["billID"];
            this.FoodID = (int)row["foodID"];
            this.Count = (int)row["count"];
        }
        private int count;
        private int foodID;
        private int billID;
        private int iD;

        public int BillID
        {
            get
            {
                return billID;
            }

            set
            {
                billID = value;
            }
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int FoodID
        {
            get
            {
                return foodID;
            }

            set
            {
                foodID = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
    }
}
