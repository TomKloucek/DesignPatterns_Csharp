using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class HappyHourStrategy : IStrategy
    {
        public double Sum(List<int> drinks)
        {
            int sum = 0;
            foreach (var drink in drinks)
            {
                sum += drink;
            }
            return sum*0.9;
        }
    }
}
