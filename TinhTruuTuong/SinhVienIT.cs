using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTruuTuong
{
    internal class SinhVienIT:SinhVien
    {
        public string HoTen { get; set; }
        public double DiemC { get; set; }
        public double DiemSQL { get; set; }
        public double DiemOOP { get; set; }
        

        private double diemTB;
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public string XepHang;

        public override void SetDiemTB()
        {
            DiemTB =  (this.DiemC + this.DiemSQL + this.DiemOOP)/3;
        }

        public double GetDiemTB()
        {
            return DiemTB;
        }

        public override void SetXepHang()
        {
            if(DiemC < 4 || DiemSQL < 4 || DiemOOP < 4)
            {
                XepHang = "Loai Yeu";
            }else if(DiemTB > 5 && DiemTB < 7)
            {
                XepHang = "Loai Trung Binh";
            }else if(DiemTB >= 7 && DiemTB < 8)
            {
                XepHang = "Loai Kha";
            }else
            {
                XepHang = "Loai Gioi";
            }
        }

    }
}
