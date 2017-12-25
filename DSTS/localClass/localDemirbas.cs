using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSTS.localClass
{
    public class localDemirbas
    {
		public int demirbasId { get; set; }
        public int fakulteId { get; set; }
        public string demirbasAdi { get; set; }
        public int demirbasAdet { get; set; }
        public decimal demirbasFiyat { get; set; }
        public int demirbasTur { get; set; }
        public string demirbasTarih { get; set; }
        public string demirbasMarka { get; set; }
        public string demirbasModel { get; set; }
        public string demirbasKod { get; set; }
		public int adet { get; set; }
		public string tur { get; set; }
		public string odaAdi { get; set; }

	}
}