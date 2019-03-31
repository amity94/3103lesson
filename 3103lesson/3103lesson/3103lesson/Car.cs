using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3103lesson
{
    class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Lecturer_ID { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Brand}, {Model}, {Year}, {Color}, {Lecturer_ID}";
        }
    }
}
