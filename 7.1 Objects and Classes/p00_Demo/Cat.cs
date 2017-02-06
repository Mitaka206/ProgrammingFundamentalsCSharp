using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00_Demo
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAsleep { get; set; }

        public void SayHello()
        {
            $"Hi, I'm {name}! I'm {age} years old.";
        }
    }
}
