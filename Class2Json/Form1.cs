using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Class2Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Lot lot = new Lot();
        string json = "";

        private void button1_Click(object sender, EventArgs e)
        {
            json = new JavaScriptSerializer().Serialize(lot);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lot.deger = "5TL";
            lot.kafesno = "208";
            lot.kafessirano = "2";
            lot.paletno = "1082";
            lot.partino = "prt00145";
            lot.tirno = "3";





            string lotonek=lot.lotOlustur();
            for (int i = 1; i < 5000; i++)
            {
                Tabaka tmp = new Tabaka();
                tmp.ilklotonek = lotonek;
                tmp.sirano = i;
                tmp.lotno = lotonek + i.ToString().PadLeft(5, '0');
                tmp.hatali = (i % 100 != 0);
                tmp.sehpano = tmp.hatali ? 3 : 1;
                tmp.girisokuma = !tmp.hatali;
                tmp.cikisokuma = tmp.girisokuma;
                lot.tabakalar.Add(tmp);             
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var yenilot = new JavaScriptSerializer().Deserialize<Lot>(json);
        }
    }
}
