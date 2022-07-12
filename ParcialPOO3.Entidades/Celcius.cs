using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO3.Entidades
{
    public class Celcius
    {
        public float Magnitud;
        public static float CeroAbsoluto;

        public Celcius()
        {
            CeroAbsoluto = -273.15f;
        }
        public Celcius(float magnitud)
        {
            Magnitud=magnitud;
        }

        public static implicit operator Celcius(float c)
        {
            return new Celcius(c);
        }

        //public static explicit operator Celcius(float c)
        //{
        //    return new Celcius(c);
        //}

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Celcius))
            {
                return false;
            }
            return this.Magnitud == ((Celcius)obj).Magnitud;
        }

        public static bool operator ==(Celcius c1, Celcius c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Celcius c1, Celcius c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Celcius c, Fahrenheit f)
        {
            return c.Equals((Celcius)f);
        }
        public static bool operator !=(Celcius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static bool operator ==(Celcius c, Kelvin k)
        {
            return c.Equals((Celcius)k);
        }
        public static bool operator !=(Celcius c, Kelvin k)
        {
            return !(c == k);
        }

        public static explicit operator Celcius(Fahrenheit f)
        {
            return new Celcius((f.Magnitud - 32) * 5 / 9);
        }
        
        public static explicit operator Celcius(Kelvin k)
        {
            return new Celcius(k.Magnitud - 273.15f);
        }

        public static Celcius operator +(Celcius c1, Celcius c2)
        {
            return new Celcius(c1.Magnitud + c2.Magnitud);
        }
        public static Celcius operator -(Celcius c1, Celcius c2)
        {
            return new Celcius(c1.Magnitud - c2.Magnitud);
        }

        public static Celcius operator +(Celcius c, Fahrenheit f)
        {
            return new Celcius(c.Magnitud + ((Celcius)f).Magnitud);
        }
        public static Celcius operator -(Celcius c, Fahrenheit f)
        {
            return new Celcius(c.Magnitud - ((Celcius)f).Magnitud);
        }

        public static Celcius operator +(Celcius c, Kelvin k)
        {
            return new Celcius(c.Magnitud + ((Celcius)k).Magnitud);
        }
        public static Celcius operator -(Celcius c, Kelvin k)
        {
            return new Celcius(c.Magnitud - ((Celcius)k).Magnitud);
        }





    }
}
