using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Məqalə başlığı boş qala bilməz");
            RuleFor(x => x.BlogTitle).NotEmpty().MinimumLength(6).WithMessage("Başlıq 6 hərfdən çox olmalıdır");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Məqalə mətni boş qala bilməz");
            RuleFor(x => x.BlogContent).NotEmpty().MinimumLength(20).WithMessage("Məqalə mətni 20 hərfdən çox olmalıdır");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Məqalə şəkili yükləməlisiniz");
            RuleFor(x => x.Category).NotNull().WithMessage("test");
            RuleFor(x => x.CategoryId).NotNull().WithMessage("test");

        }
    }
}
