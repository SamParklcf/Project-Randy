namespace Randy.DesignPatterns.Momento
{
    public class State
    {
        public State(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public object Value { get; }
    }
}