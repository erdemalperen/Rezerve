using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    internal class AboutValidator : AbstractValidator<About>



            
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Kalamaz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Secin");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En Az 50 Karakter Kullanaabilirsiniz");


        }


    }





}
