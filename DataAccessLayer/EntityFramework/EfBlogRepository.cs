using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListwithCategory()
		{
			//blog altında category entity sinden veri çekme işlemi
			using (var c = new Context())
			{
				return c.Blogs.Include(x => x.Category).ToList();  //burada hangi entity include edilecekse onun adı verilir.
			}
				
		}
	}
}
