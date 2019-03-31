using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3103lesson
{
    class Lecturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Car_ID { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Title}, {Car_ID}";
        }

    }
}
