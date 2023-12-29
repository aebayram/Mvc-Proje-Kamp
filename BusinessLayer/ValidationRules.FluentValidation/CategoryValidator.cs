using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
	public class CategoryValidation : AbstractValidator<Category>
	{
		public CategoryValidation()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçiremezsiniz!.");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz!.");
			RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız!.");
			RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Değer Girişi Yapmayın!.");
		}
		//public ValidationResult Validate(Category p)
		//{
		//	throw new NotImplementedException();
		//}
	}
}