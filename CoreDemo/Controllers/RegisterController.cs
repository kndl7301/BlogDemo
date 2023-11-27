﻿using BussinesssLayer.Concrete;
using BussinesssLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
		WriterManager wm = new WriterManager(new EfWriterRepository());	

		[HttpGet]
		public IActionResult Index()
		{


			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{

			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);

			if(results.IsValid)
			{

				p.WriterStatus = true;
				p.Writerbout = "Deneme Test";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");

			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}



	}
}
