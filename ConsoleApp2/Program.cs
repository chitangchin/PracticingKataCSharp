using ClassLibrary2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointStruct point = new PointStruct(10, 12);
            PointStruct point2 = point;

            Console.WriteLine(point.Sum); // Output: 10
            Console.WriteLine(point2.Sum); // Output: 99
            Console.WriteLine();

            Distance test = new Distance(3, 4);
            Console.WriteLine(test.Magnitude); // Output: 5
            Console.WriteLine(test.Angle); // Output: 0.9272952180016122
            Console.WriteLine(test.Direction); // Output: 53.13010235415599
            Console.WriteLine();

            DerivedClassA derivedClassA = new DerivedClassA();
            Console.WriteLine();
            DerivedClassA derivedClassB = new DerivedClassA(10, 20);
            Console.WriteLine();

            Person p = new Person();
            p.Name = "Brandon";
            Person p2 = p;
            p.Name = "Test";
            Console.WriteLine(p.Name);

        }
    }
}
