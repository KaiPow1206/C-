using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class sinhvien
    {
        #region khai báo biến
        // khai báo biến 
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region constructor
        // khai báo constructor
        public sinhvien()
        {
            this.maSV = 0;
            this.tenSV = "No Name";
            this.diemThiDH = 0;
        }
        // khai báo constructor ( dữ liệu người dùng nhập vào)
        public sinhvien(int maSV, string tenSV,float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH=diemThiDH;
        }
        #endregion
        #region properties
        // khai báo properties để có thể truy xuất dữ liệu
        public string TenSV
        {
            get { return tenSV; }// get để giá trị để đọc
            set { tenSV = value; }//set giá trị 
        }
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public float DiemThiDH
        {
            get { return diemThiDH; }
            set {  diemThiDH = value; }
        }
        #endregion
        #region phương thức
        //phương thức 
        // phương pháp tostring 
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }
        private bool checkdiemthidh()
        {
            return(this.diemThiDH -21 >=0);
        }
        public void Xuatthongtin()
        {
            if(checkdiemthidh()==false) 
            {
                Console.WriteLine("điểm dưới 21, cần kiểm tra HS sinh viên này");
            }
            else
            {
                Console.WriteLine(ToString());  
            }
        }
        public int Tong(int x, int y)
        {
            return x + y ;
        }
        public int Tong(int x, int y, int z)
        {
            return x + y + z;
        }// overide

        //parameter list method
        // tính tổng điểm kết thúc hk của sv
        public float diemTrungBinh(params float[] mang)
        {
            int tong = 0;
            foreach(int f in mang) 
            {
                tong += f;
            }
            return (tong / mang.Count());
        }
        #endregion
    }   
}