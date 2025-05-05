using ClassLibrary2;

namespace ConsoleApp2
{
    class Square(int side) : Shape
    {
        public override int GetArea() => side * side;
        public void DisplayArea()
        {
            Console.WriteLine($"Area of square: {GetArea()}");
        }
    }
}
