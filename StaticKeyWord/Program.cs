using System;
using StaticClass;
using NonStaticClass;

namespace StaticExample
{
    class Program
    {
        static void Main(String[] args){
            //Calculator cl = new Calculator();   //can't create instance of a static class
            Calculator.Num1 = 12;
            Calculator.Num2 = 13;
            Calculator.result = Calculator.Addition();
            Console.WriteLine(Calculator.result);   

            BlockChain bc = new BlockChain();
            Console.WriteLine(bc.UserName("Sujon Chondro Shil"));
            Console.WriteLine(BlockChain.RemainAuthoriser());  //Calling static members without object

             Console.WriteLine(bc.UserName("Mr. XX"));
            Console.WriteLine(BlockChain.RemainAuthoriser());  

             Console.WriteLine(bc.UserName("Mr. YY"));
            Console.WriteLine(BlockChain.RemainAuthoriser());        
        }
    }
}
