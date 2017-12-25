using DSTS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
    public class GuncellemeController : Controller
    {
        business bl = new business();

        public ActionResult OdadakiDemirbasiGuncelle()
        {
            return View();
        }



        public ActionResult OdaBilgileriniGuncelleme()
        {
            ViewBag.personeller = bl.PersonelAdi();
            return View();
        }

        public ActionResult OdaBilgiGuncelle(string odaAdi, string odaId, string personelId)
        {
            bl.OdaBilgiGuncelle(odaAdi, odaId, personelId);
            return View(OdaBilgileriniGuncelleme());
        }

        public JsonResult GetFakulte()
        {
            return Json(bl.FakulteAdi(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOda(int intFakId)
        {
            return Json(bl.OdaAdiGetir().Where(p => p.fakulteId == intFakId), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOdaDemirbas(int odaId)
        {
            return Json(bl.OdadakiDbGetir(odaId), JsonRequestBehavior.AllowGet);
        }

        public ActionResult odaDBGuncelle(string odaId, string dbId, string adet)
        {
            bl.OdadakiDBGuncelle(odaId, dbId, adet);
            return View(OdadakiDemirbasiGuncelle());
        }
    }
}