using System;
using PointsAndLines;

class Human
{
    public int Height;
    public int Weight;

    public Human(int height , int weight)
    {
        Height = height;
        Weight = weight;
    }

}
class EveryPoint
    {
        static void Main()
        {
        User user = new User("richard",Race.Earthing);
        Console.WriteLine(user.Username);

        User secondUser = new User();
        Console.WriteLine(secondUser.ID);

        User thirdUser = new User();
        Console.WriteLine(thirdUser.ID);

        Console.WriteLine(User.currentID);
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Utilities.ColorfulWriteLine(user.Username, System.ConsoleColor.DarkRed);
    }



}

