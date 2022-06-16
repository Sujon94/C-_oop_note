namespace StaticClass
{
    public static class Calculator
    {
        public static int result = 0;
        //private int num1 = 0;   //Not allowed. Only static component allowed
        private static int num1 = 0;
        private static int num2 = 0;

        public static int Num1{
            get{
                return num1;
            }set{
                num1 = value;
            }
        }
        public static int Num2{
            get{
                return num2;
            }set{
                num2 = value;
            }
        }
        public static int Addition(){
            return num1+num2;
        }

        public static int Subtraction(){
            return num1 - num2;
        }
    }
}