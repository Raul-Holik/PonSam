using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonSam
{
    class Brojevi
    {
        double broj;
        public double Broj { get => broj; set => broj = value; }

        public virtual double ApsVrijednost()
        {
            return 0;
        }
    }
    class Cijeli:Brojevi
    {
        public override double ApsVrijednost()
        {
            return Broj;
        }
    }
    class Decimalni : Brojevi
    {
        public override double ApsVrijednost()
        {
            Broj = 100.45;
            return Broj;
        }
    }
    class Pozitivni:Cijeli
    {
        public override double ApsVrijednost()
        {
            Broj = 100;
            return Broj;
        }
    }
    class Negativni : Cijeli
    {
        public override double ApsVrijednost()
        {
            Broj = -100;
            return Broj;
           
        }
        public override string ToString()
        {
            Broj = Convert.ToString();
            return Broj;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Negativni y = new Negativni();
            Decimalni z = new Decimalni();

            x.ApsVrijednost();
            y.ApsVrijednost();
            z.ApsVrijednost();

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());
            Console.ReadKey();
        }
    }
}
