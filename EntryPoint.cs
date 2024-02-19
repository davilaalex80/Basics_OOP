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
        //*Regarding STATICS* 
        //On every instantiation of the User class, the currentId gets incremented by one, since its static it is shared among all classes.
        //and the id remembers the current value of every instnace, so that we dont loce the count after a new Class was instantiated.
        User firstUser = new("vanilla");
        User secondUser = new User();
        User thirdUser = new User();

        Console.WriteLine(firstUser.id);
        Console.WriteLine(secondUser.id);
        Console.WriteLine(thirdUser.id);

        Console.Write(User.currentID); // this keeps track of how many id we have until now

        //how do I know when to call user and when to call User?
        //Console.WriteLine(user.Username);
    }
}