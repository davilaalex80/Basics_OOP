using IntroOOP.PointAndLines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EntryPoint
{
    static void Main()
    {
        User user = new User("vanilla");
        Console.Write(User.ID + " ");
        User secondUser = new User();

        //how do I know when to call user and when to call User?
        //Console.WriteLine(user.Username);
        Console.WriteLine(User.ID);

        //Console.WriteLine("the password is " + user.Password);
        //user.Username = "ab";
    }
}