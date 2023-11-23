using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçiremezsiniz!.");
			RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz!.");
			RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Geçemezsiniz!.");
			RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmını Boş Geçemezsiniz!.");
			//RuleFor(k => k.WriterAbout).Must(a => a.ToLower().Contains("a")).WithMessage("Hakkında kısmında en az bir defa 'a' harfi kullanılmalıdır");
			RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız!.");
			RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın!.");

		}
	}
}
