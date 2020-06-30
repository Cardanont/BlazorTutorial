using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidators
{
    class EmailDomainValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings[1].ToUpper() == "PRAGMTECH.COM")
                return null;

            return new ValidationResult("Domain must be PragmTech.com",
                new[] { validationContext.MemberName });
        }
    }
}
