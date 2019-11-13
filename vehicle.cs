using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Vehicle
    {
        private string Color { get; set; }

        private int Speed { get; set;}

        private int WheelCount { get; set; }

        //constructor

        public Vehicle(string color, int wheelcount)
        {
            Color = color;
            WheelCount = wheelcount;
        }

        public string GetVehicleInfo()
        {
            var info = string.Format("Color : {0}, Speed {1}, " + 
                "WheelCount {2}", Color, Speed, WheelCount);
            return info;
        }

        public void Start()
        {
            Speed = 20;
        }

        public void Stop ()
        {
            Speed = 0;
        }

        public void Accelerate(int value)
        {
            Speed += value;
        }

        public void DeAccelerate(int value)
        {
            Speed = Speed- value;
        }
    }
}
