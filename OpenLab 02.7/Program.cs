using System;

namespace OpenLab_02._7
{
    class Program
    {
        public static bool vianoce(int den, int mesiac, int rok)
        {
            if (den == 24 && mesiac == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj deň");
            int den = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj mesiac");
            int mesiac = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj rok");
            int rok = int.Parse(Console.ReadLine());
            Console.WriteLine(vianoce(den, mesiac, rok));
        }
    }
}
