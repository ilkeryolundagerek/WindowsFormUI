using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormUI
{
    public interface IZar
    {
        int At();
    }
    public class Zar : IZar
    {
        private int yuz_sayisi;
        private static readonly Random r = new Random();
        public Zar(int yuz_sayisi)
        {
            this.yuz_sayisi = yuz_sayisi;
        }
        public int At()
        {
            return r.Next(yuz_sayisi) + 1;
        }
    }
    //base: Kalıtımda temel(base) sınıfın yapıcı metodu parametre istiyorsa :base(parametre) yapısı ile gönderilir.
    public class Para : Zar
    {
        public Para() : base(2) { }
    }

    public class Tavla : Zar
    {
        public Tavla() : base(6) { }
    }
}
