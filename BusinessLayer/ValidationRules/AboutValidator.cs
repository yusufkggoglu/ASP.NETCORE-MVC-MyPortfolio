using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad boş geçilemez !");
            RuleFor(x => x.Introduction).NotEmpty().WithMessage("Rol boş geçilemez !");
            RuleFor(x => x.FileUrl).NotEmpty().WithMessage("CV Url boş geçilemez !");
            RuleFor(x => x.BackgroundUrl).NotEmpty().WithMessage("Arka kapak url boş geçilemez !");
            RuleFor(x => x.AboutHeader).NotEmpty().WithMessage("Hakkımda başlık boş geçilemez !");
            RuleFor(x => x.AboutContent).NotEmpty().WithMessage("Hakkımda açıklama boş geçilemez !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş geçilemez !");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon boş geçilemez !");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres boş geçilemez !");
            RuleFor(x => x.ProfileUrl).NotEmpty().WithMessage("Profil Url boş geçilemez !");
            RuleFor(x => x.TwitterUrl).NotEmpty().WithMessage("Twitter Url boş geçilemez !");
            RuleFor(x => x.InstagramUrl).NotEmpty().WithMessage("Instagram Url boş geçilemez !");
            RuleFor(x => x.LinkedinUrl).NotEmpty().WithMessage("Linkedin Urlboş geçilemez !");
            RuleFor(x => x.GithubUrl).NotEmpty().WithMessage("Github Url boş geçilemez !");
        }
    }
}
