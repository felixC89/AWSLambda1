using AWSLambda1.RequestModel;
using FluentValidation;

namespace AWSLambda1.Validators
{
    public class ValidatorSaludo : AbstractValidator<RequestSaludo>
    {
        public ValidatorSaludo()
        {
            RuleFor(saludo => saludo.key1)
                .NotNull().WithMessage("El primer parametro no puede ser vacío");
            RuleFor(saludo => saludo.key2)
                .NotNull().WithMessage("El segundo parametro no puede ser vacío");
            RuleFor(saludo => saludo.key3)
                .NotNull().WithMessage("El tercer parametro no puede ser vacío");
            RuleFor(saludo => saludo.key4)
                .NotNull().WithMessage("El cuarto parametro no puede ser vacío");
        }
    }
}
