using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        public string setName();
        public string buildFrame();
        public int buildEngine();
        public int buildWheels();
        public string buildTransmission();
    }

    public class DaewooLanosBuilder : ICarBuilder
    {
        private Car car {  get; set; }
        public DaewooLanosBuilder()
        {
            car = new Car();
        }
        public int buildEngine()
        {
            car.Engine = 98;
            return car.Engine;
        }

        public string buildFrame()
        {
            car.Frame = "Sedan";
            return car.Frame;
        }

        public string buildTransmission()
        {
            car.Transmission = "5 Manual";
            return car.Transmission;
        }

        public int buildWheels()
        {
            car.Wheels = 13;
            return car.Wheels;
        }

        public string setName()
        {
            car.Name = "Daewoo Lanos";
            return car.Name;
        }
    }

    public class FordProbeBuilder : ICarBuilder
    {
        private Car car { get; set; }
        public FordProbeBuilder()
        {
            car = new Car();
        }
        public int buildEngine()
        {
            car.Engine = 160;
            return car.Engine;
        }

        public string buildFrame()
        {
            car.Frame = "Coupe";
            return car.Frame;
        }

        public string buildTransmission()
        {
            car.Transmission = "4 Auto";
            return car.Transmission;
        }

        public int buildWheels()
        {
            car.Wheels = 14;
            return car.Wheels;
        }

        public string setName()
        {
            car.Name = "Ford Probe";
            return car.Name;
        }
    }

    public class UAZPatriotBuilder : ICarBuilder
    {
        private Car car { get; set; }
        public UAZPatriotBuilder()
        {
            car = new Car();
        }
        public int buildEngine()
        {
            car.Engine = 120;
            return car.Engine;
        }

        public string buildFrame()
        {
            car.Frame = "Universal";
            return car.Frame;
        }

        public string buildTransmission()
        {
            car.Transmission = "4 Manual";
            return car.Transmission;
        }

        public int buildWheels()
        {
            car.Wheels = 16;
            return car.Wheels;
        }

        public string setName()
        {
            car.Name = "UAZ Patriot";
            return car.Name;
        }
    }

    public class HyundaiGetzBuilder : ICarBuilder
    {
        private Car car { get; set; }
        public HyundaiGetzBuilder()
        {
            car = new Car();
        }
        public int buildEngine()
        {
            car.Engine = 66;
            return car.Engine;
        }

        public string buildFrame()
        {
            car.Frame = "Hatchback";
            return car.Frame;
        }

        public string buildTransmission()
        {
            car.Transmission = "4 Auto";
            return car.Transmission;
        }

        public int buildWheels()
        {
            car.Wheels = 13;
            return car.Wheels;
        }

        public string setName()
        {
            car.Name = "Hyundai Getz";
            return car.Name;
        }
    }
}
