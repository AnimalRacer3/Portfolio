using PackageTracker.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker.Presenters.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> result = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, result, true);
            if (!isValid) 
            {
                foreach (ValidationResult validationResult in result)
                {
                    errorMessage += "- " + validationResult.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }
        }
    }

    // Validates DateTime
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (!PackageView.Instance.IsDeliveryDate)
            {
                return true;
            }
            if (value is DateTime date)
            {
                return date > DateTime.Now;
            }

            return false;
        }
    }
}
