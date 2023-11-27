using BussinesssLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsletterDal;

		public NewsLetterManager(INewsLetterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsletterDal.Insert(newsLetter);
		}
	}
}
