using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    class DSGiaoVien
    {
        List<GiaoVien> giaoViens = new List<GiaoVien>();

        internal List<GiaoVien> GiaoViens
        {
            get
            {
                return giaoViens;
            }

            set
            {
                giaoViens = value;
            }
        }

        public void docFile(String file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodes = read.SelectNodes("/DanhSach/GV");
            foreach(XmlNode node in nodes)
            {
                GiaoVien gv = new GiaoVien();
                gv.HoTen = node["HoTen"].InnerText;
                gv.SoNhom = int.Parse(node["SoNhom"].InnerText);
                giaoViens.Add(gv);
            }
        }

        public int tinhTongSoNhom()
        {
            int tong = 0;
            foreach(GiaoVien gv in giaoViens)
            {
                tong += gv.SoNhom;
            }
            return tong;
        }
        public void sapXepTen()
        {
            giaoViens = giaoViens.OrderBy(t => t.HoTen).ToList();
        }
        public void sapXepNhom()
        {
            giaoViens = giaoViens.OrderByDescending(t => t.SoNhom).ToList();
        }
        public List<GiaoVien> locSoNhomHon1()
        {
            return giaoViens.Where(t => t.SoNhom > 1).ToList();
        }
        public void xuat()
        {
            Console.WriteLine("Danh Sach Giao Vien");
            foreach(GiaoVien gv in giaoViens)
            {
                gv.Xuat();
            }
        }
    }
}
