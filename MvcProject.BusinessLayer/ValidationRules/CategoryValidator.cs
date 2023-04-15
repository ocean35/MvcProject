using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Category name can not be empty. Please enter valid value.")
                .MinimumLength(3).WithMessage("Category name can not be less than 3 character. Please enter valid value")
                .MaximumLength(50).WithMessage("Category name can not be more than 50 character. Please enter valid value");


            RuleFor(x=> x.CategoryDescription)
                .NotEmpty().WithMessage("Category description can not be empty. Please enter a valid text.")
                .MinimumLength(3).WithMessage("Category description can not be less than 3 character. Please enter valid value")
                .MaximumLength(200).WithMessage("Category description can not be more than 50 character. Please enter valid value");
        }
    }
}
