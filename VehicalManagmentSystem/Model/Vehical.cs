using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicalManagmentSystem.Model
{
    public class Vehicle
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int SeatingCapacity { get; init; }
        public String FuelTankSize { get; init; }
        public string FuelType { get; init ; }
        public string VehicleType { get; init ; }
        public int HeadLightCount { get; init; }
        public int TailLightCount { get; init; }
        public int IndicatorCount { get; init; }
        public int ExhuastCount { get; init; }
        public int WheelsCount { get; init; }

        public void StartVehicle()
        {
            Console.WriteLine("Start the engine");
        }

        public void StopVehicle()
        {
            Console.WriteLine("Stop the engine");
        }
    }
    public enum VehicleType
    {
        TwoWheelerVehicle = 1,
        FourWheelerVehicle = 2,
    }

}
