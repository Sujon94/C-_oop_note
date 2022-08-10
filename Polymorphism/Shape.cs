using System;

namespace ShapeSpace
{
    public class Shape
    {
        public void draw(int a, int b){
            Console.WriteLine("Drawing a shape. "+ (a+b));
        }

        public void draw(string a, string b){
            Console.WriteLine("Drawing a shape. "+(a+b));
        }

        // public void draw(int a=20, int b=40){
        //     Console.WriteLine("Drawing a shape. "+(a+b));
        // }

        // public int draw(int a, int b){
        //     return a+b+c;
        // }

        public int draw(int a, int b, int c){
            return a+b+c;
        }
    }
}