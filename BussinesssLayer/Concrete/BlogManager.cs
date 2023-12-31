﻿using BussinesssLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLayer.Concrete
{
	public class BlogManager : IBlogService
	{

		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogyUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListwithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x=>x.BlogID==id);
		}
		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}

		
		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogListWithWriter(int id)
		{

			return _blogDal.GetListAll(x => x.WriterID == id);
		}

		public List<Blog> GetListAll()
		{
			throw new NotImplementedException();
		}
	}
}
