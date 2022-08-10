using System;
using RectangleSpace;
using ShapeSpace;

namespace Program
{
    class Program{
        static void Main(String[] args){
            Shape shape = new Shape();
            shape.draw(1,2);
            shape.draw("A","B");
            Console.WriteLine(shape.draw(1,2,3));
        }
    }
}


