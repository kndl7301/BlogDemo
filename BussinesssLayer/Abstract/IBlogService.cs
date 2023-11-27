using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLayer.Abstract
{
	public interface IBlogService
	{

		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogyUpdate(Blog blog);

		List<Blog> GetList();
		Blog GetById(int id);

		List<Blog> GetBlogListWithCategory();
		List<Blog> GetListAll();

		List<Blog> GetBlogListWithWriter(int id);

	}
}
