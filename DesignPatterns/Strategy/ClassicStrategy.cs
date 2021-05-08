using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class ClassicStrategy : IStrategy
    {
        public double Sum(List<int> drinks)
        {
            int sum = 0;
            foreach(var drink in drinks)
            {
                sum += drink;
            }
            return sum;
        }
    }
}
