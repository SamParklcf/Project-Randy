namespace Randy.DesignPatterns.Momento.Validators
{
    using FluentValidation;

    public class StateParameterValidator : AbstractValidator<StateParameter>
    {
        public StateParameterValidator()
        {
            RuleFor(x => x.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithSeverity(Severity.Error)
                .WithMessage(x => $"{nameof(x.Name)} of the state is not provided.");
        }
    }
}