using System;

namespace Composite
{
    public class BinaryExpression : Expression
    {
        private readonly Expression _leftExpression;
        private readonly Expression _rightExpression;
        private readonly Func<double, double, double> _operation;
        public BinaryExpression(Expression left, Expression right, Func<double, double, double> operation)
        {
            _leftExpression = left;
            _rightExpression = right;
            _operation = operation;
        }

        public override double Eval => _operation(_leftExpression.Eval, _rightExpression.Eval);
        public override string Print => _leftExpression.Print + "\t" + _rightExpression.Print;
    }
}