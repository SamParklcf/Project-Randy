namespace Randy.DesignPatterns.Momento
{
    using System;
    using System.Collections.Generic;

    using Randy.DesignPatterns.Momento.Abstractions;

    /// <summary>
    /// Represents a base class for providing functionalities which gives snapshot details.
    /// </summary>
    public class Momento : IMomento
    {
        /// <summary> Holds <see cref="DateTime"/> of the snapshot. </summary>
        private DateTime _momentoTime;

        /// <summary> Initializes a new instance of <see cref="Momento"/> class. </summary>
        /// <param name="states"> List of states which should be stored. </param>
        public Momento(IList<StateParameter> states)
        {
            States = states;

            _momentoTime = DateTime.Now;
        }

        /// <inheritdoc cref="IState.GetState"/>
        protected IList<StateParameter> States { get; set; }

        /// <inheritdoc/>
        public DateTime GetMomentoTime()
        {
            return _momentoTime;
        }

        /// <inheritdoc/>
        public IList<StateParameter> GetState()
        {
            return States;
        }
    }
}