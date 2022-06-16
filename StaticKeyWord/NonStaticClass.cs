namespace NonStaticClass
{
    class BlockChain{
        static int counter = 3;
        private string name = "Demo Program";

        public string UserName(string userName){
            name = userName;
            counter--;  //Static member
            return "Authorised user name: "+ name + "Authorised at: "+DateTime.Now;
        }

        public static int RemainAuthoriser(){
            return counter; //Can access only static members
        }

    }
}