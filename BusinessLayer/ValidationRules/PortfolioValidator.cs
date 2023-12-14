using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Proje adı boş geçilemez !");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Proje açıklaması boş geçilemez !");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Proje durumu boş geçilemez !");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje resmi boş geçilemez !");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Proje adı en az 5 karakterden oluşmalıdır !");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Proje adı en az 10 karakterden oluşmalıdır !");
        }
    }
}
