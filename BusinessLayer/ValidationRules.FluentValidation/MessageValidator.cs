using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
	public class MessageValidator: AbstractValidator<Message>
	{
		public MessageValidator() 
		{
			RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz!.");
			RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz!.");
			RuleFor(x => x.MessageContant).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz!.");
			RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("E-posta Adresini Boş Geçemezsiniz.").EmailAddress().WithMessage("Geçersiz e-posta adresi.");
			RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 Karakterden Fazla Değer Girişi Yapmayın!"); 

		}
	}
}
