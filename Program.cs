using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "white";
            fxs.MaximumOccupancy = "Two";

            Tesla modelS = new Tesla();
            modelS.MainColor = "black";
            modelS.MaximumOccupancy = "four";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "pink";
            mx410.MaximumOccupancy = "fifty";

            Ram dodge = new Ram();
            dodge.MainColor = "red";
            dodge.MaximumOccupancy = "four";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine("---------------");

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            Console.WriteLine("---------------");

            mx410.Drive();
            mx410.Turn("up");
            mx410.Stop();

            Console.WriteLine("---------------");

            dodge.Drive();
            dodge.Turn("anywhere it wants to go");
            dodge.Stop();
        }
    }
}
