using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{

    public class Min18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {


            var employee = (Employee)validationContext.ObjectInstance;

            if (employee.Age == 0 ||
                employee.Age == 1)
                return ValidationResult.Success;


            return (employee.Age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership.");





        }
    }
}
