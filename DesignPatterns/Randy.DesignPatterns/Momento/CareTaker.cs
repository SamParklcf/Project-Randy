namespace Randy.DesignPatterns.Momento
{
    using System.Collections.Generic;
    using System.Linq;

    using Randy.DesignPatterns.Momento.Abstractions;

    /// <summary>
    /// Represents a base class for Providing functionalities to take care of snapshots of the
    /// <typeparamref name="T"/> object.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    public class CareTaker<T> : ICareTaker<T>
        where T : ISnapshot, new()
    {
        /// <summary> Initializes a new instance of <see cref="CareTaker{T}"/> class. </summary>
        /// <param name="originator"> Originator which should be take care of it's snapshots. </param>
        public CareTaker(T originator)
        {
            Momentos = new List<IMomento>();
            Originator = originator;
        }

        /// <summary> Gets list of all momentos of the <typeparamref name="T"/>. </summary>
        protected IList<IMomento> Momentos { get; }

        /// <summary> gets the originator which should be take care of it's snapshots. </summary>
        protected T Originator { get; }

        /// <inheritdoc/>
        public IList<IMomento> GetAllSnapshots()
        {
            return Momentos;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public virtual void TakeSnapshot()
        {
            Momentos.Add(Originator.TakeSnapshot());
        }
    }
}