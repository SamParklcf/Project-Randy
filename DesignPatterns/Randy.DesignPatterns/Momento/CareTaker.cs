namespace Randy.DesignPatterns.Momento
{
    using System.Collections.Generic;
    using System.Linq;

    using Randy.DesignPatterns.Momento.Abstractions;

    public class CareTaker<T> : ICareTaker
        where T : ISnapshot, new()
    {
        public CareTaker(T originator)
        {
            Momentos = new List<IMomento>();
            Originator = originator;
        }

        protected IList<IMomento> Momentos { get; }
        protected T Originator { get; }

        public IList<IMomento> GetAllSnapshots()
        {
            return Momentos;
        }

        public virtual void RestoreSnapshot(bool cascade = false)
        {
            if (!Momentos.Any())
                return;

            var momento = Momentos.Last();
            Momentos.Remove(momento);

            try
            {
                Originator.RestoreSnapshot(momento);
            }
            catch
            {
                if (cascade)
                    RestoreSnapshot(cascade);
                else
                    throw;
            }
        }

        public virtual void TakeSnapshot()
        {
            Momentos.Add(Originator.TakeSnapshot());
        }
    }
}