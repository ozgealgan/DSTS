using DSTS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS.Controllers
{
	public class LoginController : baseController
	{
		business bl = new business();
		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(string kulAdi, string parola)
		{
			var data = bl.Login(kulAdi, parola);
			if (data.personelAdi != null)
			{
				Session.Timeout = 120;
				Session.Add("kullaniciAdi", data.personelAdi);
				Session.Add("yetki", data.yekiId);
				return Redirect("/Home/Index");
			}
			else
			{
				ViewBag.mesaj = "Kullanıcı Adı yada parola hatalı!";
				return View();
			}
		}


			public ActionResult LogOut()
			{
				Session["yetki"] = null;
				Session["kullaniciAdi"] = null;
				Session.Abandon();
				return RedirectToAction("Index", "Login");
			}
	}
}
