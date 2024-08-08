using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public void Start()
        {
            Console.WriteLine("Engine start");
        }
        public void Stop()
        {
            Console.WriteLine("Break");
        }
        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
