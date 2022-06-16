using System;
using System.Text;

namespace ConstStaticReadonly
{
    class Variables
    {
        const string co="Constant";
        readonly string re = "Readonly";

        readonly static string assign;
        readonly static string sre = " Static Readonly";

        static Variables(){
            //co = "Another"; //Can't reassign
            //re = "Another Readonly"; //Can't reassign

            assign = sre;
            sre = "Another Readonly";
            Console.WriteLine(assign +" "+ sre);
        }

        public Variables(){
            //co = "Another another"; //Can't reassign
            re = "Another Another Readonly"; //Can reassign
            //Console.WriteLine(re);

            //assign = sre; //Can't reassign
            //sre = "Another Readonly"; //Can't reassign
            //Console.WriteLine(assign +" "+ sre);
        }

        public Variables(string value){
            //co = "Another another another"; //Can't reassign
            re = value+" Another Another Another Readonly"; //Can reassign
            Console.WriteLine(re);

            //assign = sre; //Can't reassign
            //sre = "Another Readonly"; //Can't reassign
            //Console.WriteLine(assign +" "+ sre);
        }

        public void TestVariable(){
            //co = "Another Another"; //Can't reassign
            //re = "Another Another Another Readonly"; //Can't reassign

            //assign = sre; //Can't reassign
            //sre = "Another Readonly"; //Can't reassign
            //Console.WriteLine(assign +" "+ sre);
        }
    }

    class Program
    {
        static void Main(String[] args){
            Variables v = new Variables();

            Console.WriteLine("Hello");
        } 
    }
}
