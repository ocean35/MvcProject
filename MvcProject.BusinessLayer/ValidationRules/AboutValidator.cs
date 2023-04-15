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
                .NotEmpty().WithMessage("The field can not be empty. Please enter a valid value")
                .NotNull().WithMessage("The field can not be empty. Please enter a valid value")
                .MinimumLength(3).WithMessage("The field can not be less than 3 character. Please enter valid value")
                .MaximumLength(1000).WithMessage("The field can not be more than 50 character. Please enter valid value");

            RuleFor(a => a.AboutDetailsSecond)
               .NotEmpty().WithMessage("The field can not be empty. Please enter a valid value")
               .NotNull().WithMessage("The field can not be empty. Please enter a valid value")
               .MinimumLength(3).WithMessage("The field can not be less than 3 character. Please enter valid value")
               .MaximumLength(1000).WithMessage("The field can not be more than 50 character. Please enter valid value");

            RuleFor(a => a.AboutImageFirst)
                 .NotEmpty().WithMessage("The field can not be empty. Please enter a valid value")
                 .NotNull().WithMessage("The field can not be empty. Please enter a valid value")
                 .MinimumLength(3).WithMessage("The field can not be less than 3 character. Please enter valid value")
                 .MaximumLength(1000).WithMessage("The field can not be more than 1000 character. Please enter valid value");


            RuleFor(a => a.AboutDetailsSecond)
                 .NotEmpty().WithMessage("The field can not be empty. Please enter a valid value")
                 .NotNull().WithMessage("The field can not be empty. Please enter a valid value")
                 .MinimumLength(3).WithMessage("The field can not be less than 3 character. Please enter valid value")
                 .MaximumLength(1000).WithMessage("The field can not be more than 1000 character. Please enter valid value");
        }
    }
}
