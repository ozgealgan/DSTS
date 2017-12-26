using System;
using DSTS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSTS.BusinessLayer;

namespace DSTS.Controllers
{
	public class HomeController : baseController
	{
		business bl = new business();

		public ActionResult Index()
		{
			//ViewBag.demirbaslar = bl.DbListele();
			//ViewBag.odalar = bl.OdaListele();
			//ViewBag.personeller = bl.PersonelListele();
			//ViewBag.fakulteler = bl.FakulteListele();
			return View();
		}

	}
}