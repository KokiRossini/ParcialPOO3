using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO3.Entidades
{
    public class Fahrenheit
    {
        public float Magnitud;
        public static float CeroAbsoluto;

        public Fahrenheit()
        {
            CeroAbsoluto = -459.67f;
        }
        public Fahrenheit(float magnitud)
        {
            Magnitud = magnitud;
        }

        public static implicit operator Fahrenheit(float f)
        {
            return new Fahrenheit(f);
        }

        //public static explicit operator Fahrenheit(float f)
        //{
        //    return new Fahrenheit(f);
        //}
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fahrenheit))
            {
                return false;
            }
            return this.Magnitud == ((Fahrenheit)obj).Magnitud;
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1.Equals(f2));
        }
        public static bool operator ==(Fahrenheit f, Celcius c)
        {
            return f.Equals((Fahrenheit)c);
        }
        public static bool operator !=(Fahrenheit f, Celcius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.Equals((Fahrenheit)k);
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            return new Fahrenheit(c.Magnitud*1.8f+32f);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((float)Math.Round(k.Magnitud * 1.8f - 459.67f));
        }


        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.Magnitud + f2.Magnitud);
        }
        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.Magnitud - f2.Magnitud);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celcius c)
        {
            return new Fahrenheit(f.Magnitud + ((Fahrenheit)c).Magnitud);
        }
        public static Fahrenheit operator -(Fahrenheit f, Celcius c)
        {
            return new Fahrenheit(f.Magnitud - ((Fahrenheit)c).Magnitud);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.Magnitud + ((Fahrenheit)k).Magnitud);
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.Magnitud - ((Fahrenheit)k).Magnitud);
        }


    }
}
