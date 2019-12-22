using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crosscutting.Attributes
{
    public class CPFAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                
                if (value != null && (value.ToString().Length == 11|| value.ToString().Length == 14))
                {
                    if (value.ToString().Length == 11|| value.ToString().Length == 14)
                    {
                        if (!ValidateCPF(value))
                        {
                            return new ValidationResult("CPF em formato invalido");
                        }
                    }
                  
                }
                else
                {
                    return new ValidationResult("CNPJ/CPF em formato invalido");
                }
            }
            catch (Exception)
            {
                return new ValidationResult("CPF em formato invalido");
            }

            return ValidationResult.Success;
        }

        private bool ValidateCPF(object value)
        {
            int valueValidLength = 11;
            string[] maskChars = new[] { ".", "-" };
            int[] multipliersForFirstDigit = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multipliersForSecondDigit = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            bool isValid = Mod11.IsValid(value.ToString().Replace(".","").Replace("-","") , valueValidLength, maskChars, multipliersForFirstDigit, multipliersForSecondDigit);

            return isValid;
        }

    
    }
}
