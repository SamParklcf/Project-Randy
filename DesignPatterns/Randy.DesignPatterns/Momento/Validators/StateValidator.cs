namespace Randy.DesignPatterns.Momento.Validators
{
    using FluentValidation;

    public class StateValidator : AbstractValidator<State>
    {
        public StateValidator()
        {
            RuleFor(x => x.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithSeverity(Severity.Error)
                .WithMessage(x => $"{nameof(x.Name)} of the state is not provided.");
        }
    }
}