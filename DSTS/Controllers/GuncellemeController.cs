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
        

        public ActionResult OdadakiDemirbasiGuncelle()
        {
            return View();
        }
        public ActionResult OdaBilgileriniGuncelleme()
        {
            return View();
        }
    }
}