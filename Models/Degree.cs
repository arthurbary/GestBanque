using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Degree
    {
        // * 1.8 + 32
        public struct Celcius
        {
            public double Temperature { get; set; }

            public static implicit operator Fahrenheit(Celcius c)
            {
                Fahrenheit f = new Fahrenheit();
                f.Temperature = c.Temperature * 1.8 + 32;
                return f;
            }
        }

        public struct Fahrenheit
        {
            public double Temperature { get; set; }

            public static explicit operator Celcius(Fahrenheit f)
            {
                return new Celcius() { Temperature = (f.Temperature - 32) / 1.8 };
            }
        }
    }
}
