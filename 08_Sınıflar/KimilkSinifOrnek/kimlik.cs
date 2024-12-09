using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KimilkSinifOrnek
{
    internal class Kimlik
    {

        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value.ToUpper(); }

        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik() 
        {
            ad = "";
            soyad = "";
            yas = 0;
            cinsiyet = 'B';
            memleket = "belirsiz";
        }

    }
}
