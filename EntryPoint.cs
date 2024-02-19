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
        User user = new User();
        user.Username = "vanilla";
        user.Password = 5;

        Console.WriteLine("the username is " + user.Username);
        Console.WriteLine("the password is "+ user.Password);
        //user.Username = "ab";
    }
}