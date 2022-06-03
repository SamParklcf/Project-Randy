namespace Randy.DesignPatterns.Momento
{
    /// <summary> Represents a base class for holding <see cref="Originator"/> states. </summary>
    public class StateParameter
    {
        /// <summary> Initializes a new instance of <see cref="StateParameter"/> class. </summary>
        /// <param name="name"> Name of the state. </param>
        /// <param name="value"> Value of the state. </param>
        public StateParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Gets or sets name of the state. </summary>
        public string Name { get; protected set; }

        /// <summary> Gets or sets value of the state. </summary>
        public object Value { get; protected set; }
    }
}