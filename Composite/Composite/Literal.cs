namespace Composite
{
    public class Literal : Expression
    {
        private readonly double _value;
        public Literal(double value)
        {
            _value = value;
        }

        public override double Eval => _value;
        public override string Print => _value.ToString();
    }
}