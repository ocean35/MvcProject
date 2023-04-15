using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(a => a.AboutDetailsFirst)
                .NotEmpty().WithMessage("")
                .NotNull().WithMessage("")
                .MinimumLength(3).WithMessage("")
                .MaximumLength(1000).WithMessage("");

            RuleFor(a => a.AboutDetailsSecond)
               .NotEmpty().WithMessage("")
               .NotNull().WithMessage("")
               .MinimumLength(3).WithMessage("")
               .MaximumLength(1000).WithMessage("");

            RuleFor(a => a.AboutImageFirst)
                 .NotEmpty().WithMessage("")
                 .NotNull().WithMessage("")
                 .MinimumLength(3).WithMessage("")
                 .MaximumLength(1000).WithMessage("");


            RuleFor(a => a.AboutDetailsSecond)
                 .NotEmpty().WithMessage("")
                 .NotNull().WithMessage("")
                 .MinimumLength(3).WithMessage("")
                 .MaximumLength(1000).WithMessage("");
        }
    }
}
