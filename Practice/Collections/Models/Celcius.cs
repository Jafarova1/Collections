using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Models
{
    public class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celcius celcius)
        {
            Kelvin kelvin = new Kelvin(celcius.Degree+273);
            return kelvin;
        }
    }
}
