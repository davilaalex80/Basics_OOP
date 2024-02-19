using IntroOOP.PointAndLines;
using System;

class EntryPoint
{
    static void Main()
    {
        //*Regarding STATICS* 
        //On every instantiation of the User class, the currentId gets incremented by one, since its static it is shared among all classes.
        //and the id remembers the current value of every instnace, so that we dont loce the count after a new Class was instantiated.
        User firstUser = new("vanilla", Race.Earthling);
        User secondUser = new User();
        User thirdUser = new User();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(firstUser.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirdUser.ID);

        Console.Write(User.currentID); // this keeps track of how many id we have until now

        //how do I know when to call user and when to call User?
        //Console.WriteLine(user.Username);
    }
}