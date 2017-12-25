using DSTS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
    public class AramaController : baseController
	{
		business bl = new business();
        // GET: Arama
		//
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
		public ActionResult OdadanDbSil(int id, string odaAdi)
		{
			bl.OdadanDbSil(id, odaAdi);
			return RedirectToAction("OdaAdinaGoreAra", "Arama");

		}

		public ActionResult DemirbasSayisiniArama()
		{
			return View();
		}

		public JsonResult DBSayisiniArama(int secim)
		{
			if(secim==1)
			{
				return Json(bl.spDemirbasAdinaGoreAra(), JsonRequestBehavior.AllowGet);
			}
			else if (secim == 2)
			{
				return Json(bl.spTuruneGoreAra(), JsonRequestBehavior.AllowGet);
			}
			else if(secim==3)
			{
				return Json(bl.spFiyatınaGoreAra(), JsonRequestBehavior.AllowGet);
			}
			else if(secim==4)
			{
				return Json(bl.spTariheGoreAra(), JsonRequestBehavior.AllowGet);
			}
				return Json(false, JsonRequestBehavior.AllowGet);
		}

		public JsonResult DemirbaslariGetir(int demirbasId)
		{
			return Json(bl.DemirbaslariGetir(demirbasId), JsonRequestBehavior.AllowGet);
		}

		
	}
}