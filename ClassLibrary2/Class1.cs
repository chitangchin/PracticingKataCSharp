using System.ComponentModel;

namespace ClassLibrary2
{
    /*
     * Members
     * - Fields
     * - Constants (called when object of a class is created)
     * - Properties 
     * - Methods
     * - Constructors
     * - Events
     * - Finalizers
     * - Indexers
     * - Operators
     * - Nested Types
     */
    public class A 
    {
        int n1, n2;
        public A()
        {
            Console.WriteLine("Default Constructor");
        }
        public A(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor");
            Console.WriteLine(n1 + n2);
        }
    }

    public class DerivedClassA : A
    {
        public DerivedClassA() : base()
        {
            Console.WriteLine("base class no param");
        }
        public DerivedClassA(int i, int j) : base(i, j)
        {
            Console.WriteLine("Derived class with param");
            Console.WriteLine(i + j);
        }
    }
    public class Person
    {
        public string? Name { get; set; } = null;
        private readonly int _socialSecurity = 0;
        public virtual void Speak()
        {
            Console.WriteLine("Woof");
        }

    }
    public struct PointStruct(double x, double y)
    {
        public readonly double Sum { get; } = x + y;
    }

    public struct Distance(double x, double y)
    {
        public readonly double Magnitude { get; } = Math.Sqrt(x * x + y * y);
        public readonly double Direction { get; } = Math.Atan2(x, y);
        public readonly double Angle { get; } = Math.Atan2(y, x) * (180 / Math.PI);
    }

    public class WierdSum(double x, double y) : Person
    { 
        public override void Speak()
        {
            Console.WriteLine("Hello");
        }
    }
}
