using FluentValidation;
using Service.DTOs.Subscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations.Subscribe
{
    public class SubscribeCreateAndUpdateDtoValidator : AbstractValidator<SubscribeCreateAndUpdateDto>
    {
        public SubscribeCreateAndUpdateDtoValidator()
        {
            RuleFor(c => c.Email).NotNull().NotEmpty().EmailAddress();
        }
    }
}
