using FluentValidation;
using Service.DTOs.Contact;
using Service.DTOs.TellUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations.Contact
{
    public class TellUsCreateAndUpdateDtoValidator :AbstractValidator<TellUsCreateAndUpdateDto>
    {
        public TellUsCreateAndUpdateDtoValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(c => c.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(c => c.Message).NotNull().NotEmpty().MaximumLength(524288)/*.Must(c => c.ToUpper().Contains("privet") == true).WithMessage("privet mutlekdir")*/;
        }
    }
}
