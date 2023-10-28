using System;
namespace DerslerDevamEdiyor.Arayuz
{
    public class CirakClass : IActionClass
    {
        public void Bolme(int Say1, int Say2)
        {
            Console.WriteLine(Say1 + " / " + Say2 + " = " + (Say1 / Say2));
        }

        public void Carpma(int Say1, int Say2)
        {
            Console.WriteLine(Say1 + " x " + Say2 + " = " + (Say1 * Say2));
        }

        public void Cikarma(int Say1, int Say2)
        {
            Console.WriteLine(Say1 + " - " + Say2 + " = " + (Say1 - Say2));
        }

        public void Topla(int Say1, int Say2)
        {
            Console.WriteLine(Say1 + " + " + Say2 + " = " + (Say1 + Say2));
        }
    }
}

