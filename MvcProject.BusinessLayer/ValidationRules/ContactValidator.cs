using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().NotNull().WithMessage("Email adress can not be empty");
            RuleFor(x => x.UserName).NotEmpty().NotNull().WithMessage("User name can not be empty");
            RuleFor(x => x.Subject).NotEmpty().NotNull().WithMessage("Subject can not be empty")
                .MinimumLength(3).WithMessage("Subject can not be less than 3 character. Please enter valid value")
                .MaximumLength(50).WithMessage("Subject can not be more than 50 character. Please enter valid value");
            RuleFor(x => x.Message).NotEmpty().NotNull().WithMessage("Message can not be empty");
        }
    }
}
