using System;

namespace gary_garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes by. Zzzzzoooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna comes to a stop after coasting a mile down the runway.");
        }
    }
}