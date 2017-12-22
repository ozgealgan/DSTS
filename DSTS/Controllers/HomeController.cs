using System;
using DSTS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
	public class HomeController : Controller
	{
		DemirbasTakipEntities db = new DemirbasTakipEntities();

		public ActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(string kulAdi, string parola)
		{
			if(db.tblPersonels.Any(x=> x.kullaniciAdi==kulAdi && x.personelParola==parola))
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewBag.mesaj = "Kullanıcı adı veya parola hatalı !";
				return View();
			}
		}
	}
}