using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var compositeExpr = new BinaryExpression(new Literal(8), new Literal(5), (x, y) => x - y);
            var compositeExpr2 = new BinaryExpression(compositeExpr, new Literal(2), (x, y) => x * y);
            var rootExpression = new BinaryExpression(new Literal(5.0), compositeExpr2, (x, y) => x + y);
            Console.WriteLine(rootExpression.Print);
            Console.WriteLine(rootExpression.Eval);
        }
    }
}
