using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class ThiSinh
    {
       // int SBD_, NamSinh_;
       // string TenThiSinh_;
        //float DiemToan_, DiemVan_, DiemNgoaiNgu_;
        public int SBD { get; set; }
        public string TenThiSinh { get; set; }
        public int NamSinh { get; set; }
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public float DiemNgoaiNgu { get; set; }
        public float TongDiem { get; set; }
        public bool KetQua { get; set; }

        public ThiSinh() { }

        public ThiSinh(int sBD, string tenThiSinh, int namSinh)
        {
            SBD = sBD;
            TenThiSinh = tenThiSinh;
            NamSinh = namSinh;
        }

        public ThiSinh(int sBD, string tenThiSinh, int namSinh, float diemToan, float diemVan, float diemNgoaiNgu)
        {
            SBD = sBD;
            TenThiSinh = tenThiSinh;
            NamSinh = namSinh;
            DiemToan = diemToan;
            DiemVan = diemVan;
            DiemNgoaiNgu = diemNgoaiNgu;
            TongDiem = (DiemToan + DiemVan + (DiemNgoaiNgu * 2));
            KetQua = TongDiem >= 25.0 ? true : false;
        }


        public void Xuat()
        {
            Console.WriteLine("Thong tin thi sinh");
            Console.WriteLine("SBD: "+SBD);
            Console.WriteLine("Ho ten: "+TenThiSinh);
            Console.WriteLine("Nam sinh: "+NamSinh);
            Console.WriteLine("Diem toan: "+DiemToan);
            Console.WriteLine("Diem van: "+DiemVan);
            Console.WriteLine("Diem ngoai ngu: "+DiemNgoaiNgu);
            Console.WriteLine("Tong diem 3 mon: "+TongDiem);
            if(KetQua)
                Console.WriteLine("Ket qua: Dau");
            else
                Console.WriteLine("Ket qua: Rot");
        }
    }
}
