using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicalManagmentSystem.Model.FourWheeler;
using VehicalManagmentSystem.Model;
using System.Xml.Linq;

namespace VehicalManagmentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TwoWheeler Access = new TwoWheeler
            {
                Id=1, 
                Name="Access", 
                VehicleType = VehicleType.TwoWheelerVehicle.ToString(), 
                SeatingCapacity=2,
                FuelTankSize="5L", 
                HeadLightCount=1, 
                TailLightCount=1, 
                IndicatorCount=4, 
                ExhuastCount=1,
                WheelsCount=4, 
                NoOfHelmet=2
            };

            TwoWheeler Activa5g = new TwoWheeler
            {
                Id = 2,
                Name = "Activa",
                VehicleType = VehicleType.TwoWheelerVehicle.ToString(),
                SeatingCapacity = 2,
                FuelTankSize = "5L",
                HeadLightCount = 1,
                TailLightCount = 1,
                IndicatorCount = 4,
                ExhuastCount = 1,
                WheelsCount = 4,
                NoOfHelmet = 2
            };

            TwoWheeler Jupiter = new TwoWheeler
            {
                Id = 3,
                Name = "Jupiter",
                VehicleType = VehicleType.TwoWheelerVehicle.ToString(),
                SeatingCapacity = 2,
                FuelTankSize = "5L",
                HeadLightCount = 1,
                TailLightCount = 1,
                IndicatorCount = 4,
                ExhuastCount = 1,
                WheelsCount = 4,
                NoOfHelmet = 2
            };

            FourWheeler Scorpio = new FourWheeler
            {
                Id=4, 
                Name="Scorpio", 
                VehicleType=VehicleType.FourWheelerVehicle.ToString(), 
                SeatingCapacity=7, 
                FuleType=FuelType.Diesel.ToString(), 
                FuelTankSize="60L", 
                HeadLightCount=2, 
                TailLightCount=2, 
                IndicatorCount=4, 
                ExhuastCount=1,
                WheelsCount=4, 
                SpeakerCount=4, 
                WindowsCount=4, 
                SeatBeltCount=4, 
                DiskBreakCount=4
            };

            FourWheeler Nexon = new FourWheeler
            {
                Id = 5,
                Name = "Nexon",
                VehicleType = VehicleType.FourWheelerVehicle.ToString(),
                SeatingCapacity = 5,
                FuleType = FuelType.Petrol.ToString(),
                FuelTankSize = "40L",
                HeadLightCount = 2,
                TailLightCount = 2,
                IndicatorCount = 4,
                ExhuastCount = 1,
                WheelsCount = 4,
                SpeakerCount = 4,
                WindowsCount = 4,
                SeatBeltCount = 4,
                DiskBreakCount = 4
            };

            FourWheeler Ciaz = new FourWheeler
            {
                Id = 6,
                Name = "Ciaz",
                VehicleType = VehicleType.FourWheelerVehicle.ToString(),
                SeatingCapacity = 5,
                FuleType = FuelType.Petrol.ToString(),
                FuelTankSize = "40L",
                HeadLightCount = 2,
                TailLightCount = 2,
                IndicatorCount = 4,
                ExhuastCount = 1,
                WheelsCount = 4,
                SpeakerCount = 4,
                WindowsCount = 4,
                SeatBeltCount = 4,
                DiskBreakCount = 4
            };

            Console.WriteLine(Access.ToString());
            Console.WriteLine(Activa5g.ToString());
            Console.WriteLine(Jupiter.ToString());
            Console.WriteLine(Scorpio.ToString());
            Console.WriteLine(Nexon.ToString());
            Console.WriteLine(Ciaz.ToString());

            TwoWheeler driveTwoWheelerVehicle = new TwoWheeler();
            driveTwoWheelerVehicle.StartTwoWheeler();
            driveTwoWheelerVehicle.StopTwoWheeler();

            FourWheeler driveFourWheelerVehicle = new FourWheeler();
            driveFourWheelerVehicle.StartFourWheeler();
            driveFourWheelerVehicle.StopFourWheeler();
        }
    }
}
