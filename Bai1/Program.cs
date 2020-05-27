using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            DSGiaoVien ds = new DSGiaoVien();
            ds.docFile("D:\\text web form\\baiktgiuaky\\Bai1\\GV.xml");
            ds.xuat();
            Console.WriteLine("Tong so nhom cua tat ca giao vien la: " + ds.tinhTongSoNhom());
            Console.WriteLine("Danh sach giao vien theo nhom giam dan");
            ds.sapXepNhom();
            ds.xuat();

            List<GiaoVien> ls = ds.locSoNhomHon1();
            Console.WriteLine("Danh sach GV day nhom hon 1 la");
            foreach (GiaoVien gv in ls)
                gv.Xuat();

            Console.ReadLine();
        }
    }
}
