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
using System.Web;
using System.Web.Mvc;
using Ninject.Website.Framework.Filters;
#endregion

namespace Forge.Web.Framework
{
	[HandleExceptions]
	public abstract class ForgeControllerBase : Controller
	{
		public EmptyResult OK()
		{
			return new EmptyResult();
		}

		public HttpException NotFound()
		{
			return HttpExceptionFactory.NotFound();
		}

		public HttpException BadRequest()
		{
			return HttpExceptionFactory.BadRequest();
		}

		public HttpException Forbidden()
		{
			return HttpExceptionFactory.Forbidden();
		}
	}
}