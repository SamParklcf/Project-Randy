namespace Randy.DesignPatterns.Momento.Validators
{
    using System;

    using FluentValidation;

    using Randy.DesignPatterns.Momento.Abstractions;

    public class MomentoValidator : AbstractValidator<IMomento>
    {
        public MomentoValidator()
        {
            RuleFor(x => x.GetMomentoTime())
                .Must(x => x != DateTime.MinValue && x != DateTime.MaxValue)
                .WithSeverity(Severity.Error)
                .WithMessage(x => $"{nameof(x.GetMomentoTime)} is provided a wrong time.");
            RuleForEach(x => x.GetState())
                .SetValidator(new StateParameterValidator())
                .OverridePropertyName(nameof(IState.GetState));
        }
    }
}