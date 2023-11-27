using BussinesssLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{

		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{

			var values = cm.GetList();
			return View(values);

		}

		
	}
}
