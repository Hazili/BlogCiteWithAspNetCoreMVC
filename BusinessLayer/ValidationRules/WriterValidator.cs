using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad və Soyad hissəsi boş ola bilməz");
            RuleFor(x => x.WriterName).MinimumLength(6).WithMessage("Hərf sayı 5 dən çox olmalıdır");
            RuleFor(x => x.WriterMailAdress).NotEmpty().WithMessage("Email hissəsi boş ola bilməz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrə boş ola bilməz");
        }
    }
}
