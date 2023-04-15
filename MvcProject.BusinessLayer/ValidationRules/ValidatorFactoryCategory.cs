using FluentValidation;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject.BusinessLayer.ValidationRules
{
    public class ValidatorFactoryCategory: ValidatorFactoryBase
    {
        private static Dictionary<Type, IValidator> validators = new Dictionary<Type, IValidator>();

        static ValidatorFactoryCategory()
        {
            validators.Add(typeof(IValidator<Category>), new CategoryValidator());
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            if (validators.TryGetValue(validatorType, out validator))
            {
                return validator;
            }
            return validator;
        }
    }
}
