using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    interface IStrategy
    {
        public double Sum(List<int> drinks);
    }
}
