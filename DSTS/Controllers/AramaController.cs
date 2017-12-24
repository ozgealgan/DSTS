using DSTS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
    public class AramaController : Controller
    {
		business bl = new business();
        // GET: Arama
        public ActionResult PersoneleGoreAra()
        {
            return View();
        }

		[HttpPost]
		public ActionResult PersoneleGoreAra(string personelAdi)
		{
			ViewBag.demirbaslar=bl.PersoneleGoreAra(personelAdi);
			return View();
		}

		public ActionResult OdaAdinaGoreAra()
		{
			return View();
		}

		[HttpPost]
		public ActionResult OdaAdinaGoreAra(string odaAdi)
		{
			ViewBag.odaPersonel = bl.spOdayaGorePersonel(odaAdi);
			ViewBag.odaDemirbas = bl.spOdayaGoreDemirbas(odaAdi);
			return View();
		}

		public ActionResult DemirbasSayisiniArama()
		{
			return View();
		}

		[HttpPost]
		public ActionResult DemirbasSayisiniArama(string aranacak, string aranacakDeger)
		{
			if(aranacak== "Demirbaş Adına Göre Ara")
			{
				ViewBag.Ad = bl.spDemirbasAdinaGoreAra(aranacakDeger);
			}
			else if(aranacak== "Demirbaş Türüne Göre Ara")
			{
				ViewBag.tur = bl.spTuruneGoreAra(aranacakDeger);
			}
			else if(aranacak== "Demirbaş Fiyatına Göre Ara")
			{
				ViewBag.fiyat = bl.spFiyatınaGoreAra(aranacakDeger);
			}
			else if(aranacak== "Demirbaş Alım Tarihine Göre Ara")
			{
				ViewBag.tarih = bl.spTariheGoreAra(aranacakDeger);
			}
		
			return View();
		}
	}
}