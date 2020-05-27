using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    class DSThiSinh
    {
        List<ThiSinh> lists = new List<ThiSinh>();

        internal List<ThiSinh> Lists
        {
            get
            {
                return lists;
            }

            set
            {
                lists = value;
            }
        }

        public void docFile(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodes = read.SelectNodes("/DSSV/ThiSinh");
            foreach (XmlNode node in nodes)
            {
                ThiSinh ts = new ThiSinh(int.Parse(node["SBD"].InnerText), node["HT"].InnerText,
                    int.Parse(node["NamSinh"].InnerText), float.Parse(node["Toan"].InnerText),
                    float.Parse(node["Van"].InnerText), float.Parse(node["NN"].InnerText));
                lists.Add(ts);
            }
        }

        public void nhap()
        {
            ThiSinh ts = new ThiSinh();
            Console.WriteLine("Nhap SBD");ts.SBD = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten thi sinh"); ts.TenThiSinh = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh"); ts.NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem toan"); ts.DiemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap van"); ts.DiemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nn"); ts.DiemNgoaiNgu = float.Parse(Console.ReadLine());

            lists.Add(ts);
        }

        public void sapXepTheoTongDiem()
        {
            lists = lists.OrderBy(t => t.TongDiem).ToList();
        }
        public void sapXepTheoTen()
        {
            foreach(ThiSinh ts in lists)
            {
                if(ts.TenThiSinh.All(t=> t==ts.TenThiSinh.First()))
                {
                    lists = lists.OrderBy(t => t.DiemToan).ToList();
                }
                else
                {
                    lists = lists.OrderBy(t => t.TenThiSinh).ToList();
                }
            }

        }
        public List<ThiSinh> locThiSinhDau()
        {
            return lists.FindAll(t => t.KetQua).ToList();
        }
        public List<ThiSinh> locThiSinhNamSinhHoacDiemToan()
        {
            return lists.Where(t => t.NamSinh >= 1995).Where(t => t.DiemToan >=9).ToList();
        }

        public void Xuat()
        {
            foreach(ThiSinh ts in lists)
            {
                ts.Xuat();
            }
        }
    }
}
