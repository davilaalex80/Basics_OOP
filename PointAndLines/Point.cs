namespace IntroOOP.PointAndLines
{
    class User
    {
        //static field are not dependant on the instance of a given class.
        //they can be accessed directly from the class without instantiating it.
        public static int currentID;

        //const is a hardcorded value in the code
        //readonly is an assigned value at runtime through code logic
        public const int MAX_HEIGHT= 180;
        public readonly int ID;

        private string username;
        private int password;
        
        //it can only get its value from the constructor
        public readonly int id;

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
            currentID++;
            id = currentID;
        }

        public User(string username)
        {
            currentID++;
            id = currentID;
            this.username = username;
        }
    }
}
