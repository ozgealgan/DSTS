using DSTS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
    public class KayitController : Controller
    {
        business bl = new business();
        // GET: Kayit
        public ActionResult StokEkle()
        {
            ViewBag.turler = bl.turAdi();
            ViewBag.fakulteler = bl.FakulteAdi();
            return View();
        }

        [HttpPost]
        public ActionResult StokEkle(string fakulteAdi, string dbAdi, string DbAdet, string dbFiyat, string dbtur, string dbMarka, string dbModel)
        {
           
            bl.StokEkle(fakulteAdi, dbAdi, Convert.ToInt32(DbAdet), Convert.ToDecimal(dbFiyat), dbtur, dbMarka, dbModel);
            return View(StokEkle());
        }

        public ActionResult OdaEkle()
        {
            ViewBag.fakulteler = bl.FakulteAdi();
            ViewBag.personeller = bl.PersonelAdi();   
            return View(bl.FakulteAdi());
        }

        [HttpPost]
        public ActionResult OdaEkle(string odaAdi, string sorumluAdi, string fakulteAdi)
        {
            bl.OdaEkle(odaAdi, sorumluAdi, fakulteAdi);
            return View(OdaEkle());
        }
    }
}