using BookStore.Business.Dependency_Injection;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Web.MVC
{
	public class MvcApplication : NinjectHttpApplication
	{
		protected override IKernel CreateKernel()
		{
			return new StandardKernel(new RepositoryModule());
		}

		protected override void OnApplicationStarted()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			base.OnApplicationStarted();
		}
	}
}
