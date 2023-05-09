using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail)
               .NotEmpty().WithMessage("Receiver mail can not be empty. Please enter valid value.")
               .EmailAddress().WithMessage("input value must be valid email adress");
            RuleFor(x => x.SenderMail)
               .NotEmpty().WithMessage("Sender mail can not be empty. Please enter valid value.")
                .EmailAddress().WithMessage("input value must be valid email adress");
            RuleFor(x => x.Subject)
               .NotEmpty().WithMessage("Subject can not be empty. Please enter valid value.");
            RuleFor(x => x.MessageContent)
               .NotEmpty().WithMessage("Message content can not be empty. Please enter valid value.");
        }
    }
}
