namespace IntroOOP.PointAndLines
{
    class User
    {
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

        }

        public User(string username)
        {
            this.username = username;
        }
    }
}
