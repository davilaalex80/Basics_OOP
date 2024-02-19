namespace IntroOOP.PointAndLines
{
    class User
    {
        //static field are not dependant on the instance of a given class.
        //they can be accessed directly from the class without instantiating it.
        public static int ID;
        private string username;
        private int password;

        public string Username
        {
            //read-only property
            get 
            { 
                return "the username is " + username; 
            } 
        }

        public int Password
        {
            
            //write-only property
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("password no cumple las condiciones");
                }
            }
        }

        public User()
        {
            ID++;
        }

        public User(string username)
        {
            ID++;
            this.username = username;
        }
    }
}
