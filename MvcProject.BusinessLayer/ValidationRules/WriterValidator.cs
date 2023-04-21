using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
               .NotEmpty().WithMessage("Writer name can not be empty. Please enter valid value.")
               .MinimumLength(2).WithMessage("Writer name can not be less than 3 character. Please enter valid value")
               .MaximumLength(50).WithMessage("Writer name can not be more than 50 character. Please enter valid value");


            RuleFor(x => x.WriterSurname)
                .NotEmpty().WithMessage("Writer surname can not be empty. Please enter a valid text.")
                .MinimumLength(3).WithMessage("Writer surname can not be less than 3 character. Please enter valid value")
                .MaximumLength(50).WithMessage("Writer surname can not be more than 50 character. Please enter valid value");

            RuleFor(x => x.WriterAbout)
              .NotEmpty().WithMessage("Writer about can not be empty. Please enter a valid text.")
              .Must(BeValidWriterAbout).WithMessage("Writer about field must contain 'a' letter.")
              .MinimumLength(3).WithMessage("Writer about can not be less than 3 character. Please enter valid value")
              .MaximumLength(50).WithMessage("Writer about can not be more than 50 character. Please enter valid value");

            RuleFor(x => x.WriterTitle)
             .NotEmpty().WithMessage("Writer title can not be empty. Please enter a valid text.")
             .Must(BeValidWriterAbout).WithMessage("Writer title field must contain 'a' letter.")
             .MinimumLength(3).WithMessage("Writer title can not be less than 3 character. Please enter valid value")
             .MaximumLength(50).WithMessage("Writer title can not be more than 50 character. Please enter valid value");
        }

        private bool BeValidWriterAbout(string about)
        {
           return about.Contains("a") || about.Contains("A") ? true : false;
        }
    }
}
