namespace IntroOOP.PointAndLines
{
    class User
    {
        private string username;
        private int password;

        public string Username
        {
            get 
            { 
                return "the username is " + username; 
            } 
            set 
            { 
                if (value.Length >= 4 && value.Length <= 10)
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("username no cumple las condiciones");
                }
            }
        }

        public int Password
        {
            get 
            { 
                return password; 
            }
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

        public User(string username, int password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
