using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VehicalManagmentSystem.Model
{
    public class TwoWheeler :Vehicle
    {
        public int NoOfHelmet { get; init; }

        public void StartTwoWheeler()
        {
            StartVehicle();
            Console.WriteLine("Start Driving");
        }

        public void StopTwoWheeler()
        {
            Console.WriteLine("Stop Driving");
            StopVehicle();
        }

        public override string ToString()
        {
            return string.Format("Here Id: {0}, Which Name is: {1}\nVehicle Type: {2}, Seating Capacity: {3},Fuel Tank Size: {4}, " +
                "HeadLight Count: {5}, TailLight Count: {6},Indicator Count: {7}, Exhaust Count: {8}, Wheels Count: {9}, NoOfHelmet: {10}\n",
                Id, Name, VehicleType, SeatingCapacity, FuelTankSize, HeadLightCount, TailLightCount, IndicatorCount, ExhuastCount,
                WheelsCount, NoOfHelmet);
        }
    }

    
}
