using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class Ship : ITransport
    {
        int Vykon { get; set; }

        public Ship(int vykon)
        {
            this.Vykon = vykon;
        }
        public void Deliver()
        {
            Console.WriteLine("Donaska lodi");
        }
    }
}
