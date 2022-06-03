namespace Randy.DesignPatterns.Momento
{
    using System;
    using System.Collections.Generic;

    using Randy.DesignPatterns.Momento.Abstractions;

    public class Momento : IMomento
    {
        private DateTime _momentoTime;

        public Momento(IList<State> states)
        {
            States = states;

            _momentoTime = DateTime.Now;
        }

        protected IList<State> States { get; set; }

        public DateTime GetMomentoTime()
        {
            return _momentoTime;
        }

        public IList<State> GetState()
        {
            return States;
        }
    }
}