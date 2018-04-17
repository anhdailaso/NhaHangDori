using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTODLL
{
    public class nguoidungdto
    {
        string tendangnhap;
        string matkhau;
        bool trangthai;
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        //public nguoidungdto(string Tendangnhap,string Matkhau,bool Trangthai)
        //{
        //    this.tendangnhap = Tendangnhap;
        //    this.matkhau = Matkhau;
        //    this.trangthai = Trangthai;

        //}

    }
}
