using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class TransportFactory
    {
        public ITransport Vytvor(int vykon, string nazev = "Truck")
        {
            if (nazev == "Ship")
            {
                return new Ship(vykon);
            }
            else
            {
                return new Truck(vykon);
            }
        }
    }
}
