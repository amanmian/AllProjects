using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication17.Models
{
    class Max18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {


                var t = Convert.ToString(value).Length;
                if (t < 15)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    return new ValidationResult("Name should be less then 15 characters");
                }
            }
            else
            {
                return new ValidationResult("Please Enter Name");

            }
        }
    }
}


    
