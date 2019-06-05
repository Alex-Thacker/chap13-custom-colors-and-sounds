using System;

namespace customcolorsandsounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero nothing = new Zero();
            nothing.MainColor = "blue";
            nothing.MaximumOccupancy = "2";
            nothing.Drive();
            nothing.Turn("left");
            nothing.Stop();

            Cessna whatsThat = new Cessna () ;
            whatsThat.MainColor = "yellow";
            whatsThat.MaximumOccupancy = "3";
            whatsThat.Drive();
            whatsThat.Turn("kitty");
            whatsThat.Stop();

            Tesla model3 = new Tesla () ;
            model3.MainColor = "white";
            model3.MaximumOccupancy = "4";
            model3.Drive();
            model3.Turn("down");
            model3.Stop();

            Ram truck = new Ram () ;
            truck.MainColor = "green";
            truck.MaximumOccupancy = "2";
            truck.Drive();
            truck.Turn("right");
            truck.Stop();
        }
    }
}
