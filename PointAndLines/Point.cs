namespace IntroOOP.PointAndLines
{
    class User
    {
        //static field are not dependant on the instance of a given class.
        //they can be accessed directly from the class without instantiating it.
        public static int currentID;

        //create a new field with my data type 'enum' called Race
        public Race race;

        //const is a hardcorded value in the code
        //readonly is an assigned value at runtime through code logic
        public readonly int MAX_HEIGHT= 180;
        public readonly int ID;

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

        //my constructor
        public User()
        {
            currentID++;
            ID = currentID;
        }

        public User(string username, Race race)
        {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;

            if (this.race == Race.Marsian)
            {
                MAX_HEIGHT++;
            }
            else if ( this.race == Race.Earthling)
            {
                MAX_HEIGHT = 180;
            }
        }
    }
}
