﻿using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLayer.Abstract
{
	public interface INewsLetterService
	{
		void AddNewsLetter(NewsLetter newsLetter);

	}
}