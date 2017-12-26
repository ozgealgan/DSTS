using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using DSTS.Controllers;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using DSTS.Models;
using DSTS.BusinessLayer;
using DSTS.localClass;
using System.Collections.Generic;

namespace DSTSUnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void EntityKontrol()
		{
			DemirbasTakipEntities db = new DemirbasTakipEntities();
		}

		[TestMethod]
		public void AramaTesti1()
		{
			int beklenen =0;

			business bl = new business();
			int sonuc = bl.OdaEkle("aa", "bb", "kk");
			Assert.AreEqual(beklenen, sonuc);
		}

		[TestMethod]
		public void AramaTesti()
		{
			List<localDemirbas> list = new List<localDemirbas>();
			list=null;
			business bl = new business();
			var personel =bl.PersoneleGoreAra("");
			Assert.AreEqual(list,personel);
		}

		[TestMethod]
		public void LogOutTesti()
		{
			AramaController signController = new AramaController(); // you should mock your DbContext and pass that in

			// Act
			var result = signController.PersoneleGoreAra() as ViewResult;

			// Assert
			Assert.IsNotNull(result.View); // add additional checks on the Model
		}
	
	}
}
