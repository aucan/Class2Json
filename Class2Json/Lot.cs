using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2Json
{
    public class Lot
    {
        public string partino;
        public string tirno;
        public string paletno;
        public string kafesno;
        public string kafessirano;
        public DateTime tarih;
        public string deger;
        public string lotonek;
        public List<Tabaka> tabakalar;

        public Lot()
        {
            tarih = DateTime.Today;
            tabakalar = new List<Tabaka>();
        }            

        public string lotOlustur()
        {
            lotonek = kafesno + tarih.ToShortDateString();
            return lotonek;           
        }
    }
}
