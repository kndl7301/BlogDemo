using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntitiyLayer.Concrete;

namespace BussinesssLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{

			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar İsmi Boş Geçilemez");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi Boş Geçilemez");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre  Boş Geçilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En az iki karakter giriniz");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen En fazla 50 karakterlik veri girişi yapın");
		
		
		}
	}
}
