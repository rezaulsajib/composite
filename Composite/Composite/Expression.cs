namespace Composite
{
    public abstract class Expression
    {
        public virtual double Eval { get; }
        public virtual string Print { get; }
    }
}