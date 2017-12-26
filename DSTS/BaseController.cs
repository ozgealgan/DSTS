using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSTS
{
	public class baseController: System.Web.Mvc.Controller
	{
		//protected override void OnActionExecuted(ActionExecutedContext filterContext)
		//{
		//	string controllerName = filterContext.RouteData.Values["controller"].ToString();
		//	string actionName = filterContext.RouteData.Values["action"].ToString();
		//	bool kontrol = controllerName == "Login" && actionName == "Index";

		//	if(!kontrol)
		//	{
		//		if (Session["yetki"] == null || ( Session["yetki"].ToString() != "1" && Session["yetki"].ToString() != "2"))
		//		{
		//			filterContext.Result = new RedirectResult("/Login/Index");
		//			return;
		//		}
				
		//	}
		//	base.OnActionExecuted(filterContext);
			
		//}
	}
}