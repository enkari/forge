#region License
// 
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2009, Enkari, Ltd.
// 
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
// 
#endregion
#region Using Directives
using System;
using CommonServiceLocator.NinjectAdapter;
using Forge.Web.Framework;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using Ninject.Web.Mvc;
#endregion

namespace Forge.Web
{
	public class ForgeApplication : NinjectHttpApplication
	{
		protected override void OnApplicationStarted()
		{
			var serviceLocator = new NinjectServiceLocator(Kernel);
			ServiceLocator.SetLocatorProvider(() => serviceLocator);

			RegisterAllControllersIn("Forge.Web");

			var bootstrapper = Kernel.Get<Bootstrapper>();

			bootstrapper.SetUpViewEngine();
			bootstrapper.RegisterRoutes();
		}

		protected override IKernel CreateKernel()
		{
			var kernel = new StandardKernel();


			return kernel;
		}
	}
}