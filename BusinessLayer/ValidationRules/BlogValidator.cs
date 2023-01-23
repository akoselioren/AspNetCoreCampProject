using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli boş geçilemez.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık kısmı en fazla 150 karakter içerebilir.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık kısmı en az 5 karakter içerebilir.");
        }
    }
}
