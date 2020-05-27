using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            DSThiSinh ds = new DSThiSinh();
            ds.docFile("D:\\text web form\\baiktgiuaky\\Bai2\\ThiSinh.xml");
            ds.Xuat();
            Console.WriteLine("Danh sach thi sinh sap xep theo tong diem");
            ds.sapXepTheoTongDiem();
            ds.Xuat();
            Console.WriteLine("Danh sach thi sinh sap xep theo ten");
            ds.sapXepTheoTen();
            ds.Xuat();
            Console.WriteLine("Danh sach thi sinh dau");
            List<ThiSinh> tsDau = ds.locThiSinhDau();
            foreach (ThiSinh ts in tsDau)
                ts.Xuat();
            Console.WriteLine("Danh sach thi sinh theo nam sinh hoac diem toan");
            List<ThiSinh> tsND = ds.locThiSinhNamSinhHoacDiemToan();
            foreach (ThiSinh ts in tsND)
                ts.Xuat();

            Console.ReadKey();
        }
    }
}
