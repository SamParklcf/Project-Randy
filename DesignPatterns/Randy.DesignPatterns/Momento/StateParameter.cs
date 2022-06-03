namespace Randy.DesignPatterns.Momento
{
    public class StateParameter
    {
        public StateParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public object Value { get; }
    }
}