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
            return View();
        }

        [HttpPost]
        public ActionResult StokEkle(string fakulteId, string dbAdi, string DbAdet, string dbFiyat, string dbtur)
        {
           
            bl.StokEkle(dbAdi, Convert.ToInt32(DbAdet), Convert.ToDecimal(dbFiyat), 2);
            return View();
        }

        public ActionResult OdaEkle()
        {
            return View();
        }
    }
}