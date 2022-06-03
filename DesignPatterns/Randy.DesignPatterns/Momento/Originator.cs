namespace Randy.DesignPatterns.Momento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FluentValidation;

    using Randy.DesignPatterns.Momento.Abstractions;
    using Randy.DesignPatterns.Momento.Validators;

    /// <summary>
    /// The Originator class can produce snapshots of its own state, as well as restore its state
    /// from snapshots when needed.
    /// </summary>
    public class Originator : IState, ISnapshot
    {
        private string _state3;

        public Originator()
        {
            _state3 = "Private";
        }

        public Originator(string state1, int state2)
        {
            State1 = state1;
            State2 = state2;
            _state3 = "Public";
        }

        public string State1 { get; protected set; }
        protected int State2 { get; set; }

        public IList<StateParameter> GetState()
        {
            return new List<StateParameter>
            {
                new StateParameter(nameof(State1), State1),
                new StateParameter(nameof(State2), State2),
                new StateParameter(nameof(_state3), _state3),
            };
        }

        public int GetState2() => State2;

        public string GetState3() => _state3;

        /// <inheritdoc/>
        public virtual void RestoreSnapshot(IMomento snapshot)
        {
            if (snapshot is null)
                throw new ArgumentNullException(nameof(snapshot));

            new MomentoValidator().ValidateAndThrow(snapshot);

            var state = snapshot.GetState();

            var state1 = state.FirstOrDefault(x => x.Name.Equals(nameof(State1)))?.Value as string;
            var state2 = state.FirstOrDefault(x => x.Name.Equals(nameof(State2)))?.Value;
            int unBoxedState2 = -1;
            if (state2 is int _state2)
                unBoxedState2 = _state2;
            var state3 = state.FirstOrDefault(x => x.Name.Equals(nameof(_state3)))?.Value as string;

            var originator = new Originator
            {
                State1 = state1,
                State2 = unBoxedState2,
                _state3 = state3
            };
            new OriginatorValidator().ValidateAndThrow(originator);

            State1 = originator.State1;
            State2 = originator.State2;
            _state3 = originator._state3;
        }

        public void SetScore(int score)
        {
            if (score <= 0)
                throw new ArgumentException($"{nameof(score)} should be greater than 0.");

            State2 = score;
        }

        /// <inheritdoc/>
        public virtual IMomento TakeSnapshot()
        {
            return new Momento(GetState());
        }

        public class OriginatorValidator : AbstractValidator<Originator>
        {
            public OriginatorValidator()
            {
                RuleFor(x => x.State1)
                    .Must(x => x.StartsWith("Hi "))
                    .WithSeverity(Severity.Error)
                    .WithMessage(x => $"{nameof(x._state3)} should starts with 'Hi '");
                RuleFor(x => x.State2)
                    .Must(x => x > 0)
                    .WithSeverity(Severity.Error)
                    .WithMessage(x => $"{nameof(x.State2)} should be greater than 0.");
                RuleFor(x => x._state3)
                    .Must(x => x == "Private" || x == "Public")
                    .WithSeverity(Severity.Error)
                    .WithMessage(x => $"{nameof(x.State1)} is not provided correct value.");

                RuleFor(x => x.GetState())
                    .Must(x => x is not null && x.Count == 3)
                    .WithSeverity(Severity.Error)
                    .WithMessage(x => $"{nameof(x.GetState)} has not valid state. state is curropted.");
                RuleForEach(x => x.GetState())
                    .SetValidator(new StateParameterValidator())
                    .OverridePropertyName(nameof(IState.GetState));
            }
        }
    }
}