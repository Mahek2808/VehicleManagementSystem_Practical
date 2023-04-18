using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VehicalManagmentSystem.Model
{
    public class FourWheeler :Vehicle
    {
        public int SpeakerCount { get; init; }
        public int WindowsCount { get; init; }
        public int SeatBeltCount { get; init; }
        public int DiskBreakCount { get; init; }
        public string FuleType { get; init; }

        public void StartFourWheeler()
        {
            StartVehicle();
            Console.WriteLine("Release hand brake");
            Console.WriteLine("Start Driving");
        }

        public void StopFourWheeler()
        {
            Console.WriteLine("Stop Driving");
            Console.WriteLine("Engage hand brake");
            StopVehicle();
        }

        public enum FuelType
        {
            Petrol = 1,
            Diesel = 2
        }

        public override string ToString()
        {
            return string.Format("Here Id: {0}, Which Name is: {1}\nVehicle Type: {2}, Seating Capacity: {3}, Fuel Type: {4}, Fuel Tank Size: {5}, " +
                "HeadLight Count: {6}, TailLight Count: {7},Indicator Count: {8}, Exhaust Count: {9}, Wheels Count: {10}, Speaker Count: {11}," +
                "Window Count: {12}, SeatBelt Count: {13}, DiskBreak Count: {14}\n",
                Id, Name, VehicleType, SeatingCapacity, FuleType, FuelTankSize, HeadLightCount, TailLightCount, IndicatorCount, ExhuastCount,
                WheelsCount, SpeakerCount, WindowsCount, SeatBeltCount, DiskBreakCount);
        }
    }

   
}
