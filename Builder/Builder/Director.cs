using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void BuildCar(ICarBuilder builder)
        {
            Console.WriteLine("Start of machine construction...\n");
            Thread.Sleep(2000);
            
            Console.WriteLine("Name: "+ builder.setName());
            Thread.Sleep(2000);
            Console.WriteLine("Frame: " + builder.buildFrame());
            Thread.Sleep(2000);
            Console.WriteLine("Engine: " + builder.buildEngine());
            Thread.Sleep(2000);
            Console.WriteLine("Wheels: " + builder.buildWheels() + " R");
            Thread.Sleep(2000);
            Console.WriteLine("Transmission: " + builder.buildTransmission() + "\n");
        }
    }
}
