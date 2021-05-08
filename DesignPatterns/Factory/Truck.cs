using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class Truck : ITransport
    {
        int Vykon { get; set; }

        public Truck(int vykon)
        {
            this.Vykon = vykon;
        }
        public void Deliver()
        {
           Console.WriteLine("Donaska autem");
        }
    }
}
