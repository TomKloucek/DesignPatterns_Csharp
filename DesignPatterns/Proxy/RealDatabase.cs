using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class RealDatabase : IDatabase
    {
        public void Request()
        {
            Console.WriteLine("Request on real database");
        }
    }
}
