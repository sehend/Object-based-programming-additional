using System;

namespace Kompleks_Hesap
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompleks k1 = new Kompleks(1,-2);
            Kompleks k2 = new Kompleks(3,5);
            Kompleks k3 = new Kompleks();

            //int a = 10;
            //double b = a;

            //k3 = k1 + k2;
            //k3 = k1 - k2;
            //k3 = k1 - 5;

            k1 = (Kompleks)10;

            k1++;

            
            //k3.Re = k1.Re + k2.Re;
            //k3.Im = k1.Im + k2.Im;

            Console.WriteLine(k1.ToString());
            Console.ReadLine();
        }
    }
}
