class Point
{
    public int x;
    public int y;
}


class EveryPoint
{
    static void Main()
    {
        Point point = new Point();

        point.x = 3;
        point.y = 5;

        System.Console.WriteLine(point.x);

        System.Console.WriteLine(point.y);

    }



}