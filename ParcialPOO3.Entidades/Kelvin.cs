using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO3.Entidades
{
    public class Kelvin
    {
        public float Magnitud;
        public static float CeroAbsoluto;

        public Kelvin()
        {
            CeroAbsoluto = 0f;
        }
        public Kelvin(float magnitud)
        {
            Magnitud = magnitud;
        }

        public static implicit operator Kelvin(float k)
        {
            return new Kelvin(k);
        }

        //public static explicit operator Kelvin(float k)
        //{
        //    return new Kelvin(k);
        //}
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Kelvin))
            {
                return false;
            }
            return this.Magnitud == ((Kelvin)obj).Magnitud;
        }
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.Equals(k2);
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1.Equals(k2));
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.Equals((Kelvin)f);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
        public static bool operator ==(Kelvin k, Celcius c)
        {
            return k.Equals((Kelvin)c);
        }
        public static bool operator !=(Kelvin k, Celcius c)
        {
            return !(k == c);
        }
        public static explicit operator Kelvin(Celcius c)
        {
            return new Kelvin(c.Magnitud +273.15f);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.Magnitud+459.67f)*5/9);
        }


        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.Magnitud + k2.Magnitud);
        }
        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.Magnitud - k2.Magnitud);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.Magnitud + ((Kelvin)f).Magnitud);
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.Magnitud - ((Kelvin)f).Magnitud);
        }

        public static Kelvin operator +(Kelvin k, Celcius c)
        {
            return new Kelvin(k.Magnitud + ((Kelvin)c).Magnitud);
        }
        public static Kelvin operator -(Kelvin k, Celcius c)
        {
            return new Kelvin(k.Magnitud - ((Kelvin)c).Magnitud);
        }

    }
}
