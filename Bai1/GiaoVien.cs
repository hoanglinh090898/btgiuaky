using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class GiaoVien
    {
        private string hoTen;
        private int soNhom;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public int SoNhom
        {
            get
            {
                return soNhom;
            }

            set
            {
                soNhom = value;
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: {0} \tSo nhom: {1}", HoTen, SoNhom);
        }
    }
}
