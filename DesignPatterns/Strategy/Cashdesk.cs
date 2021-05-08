using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class Cashdesk
    {
        public IStrategy strategy;
        public List<int> drinks;
        public Cashdesk(IStrategy strategy = null)
        {
            if (strategy == null)
            {
                this.strategy = new ClassicStrategy();
            }
            else
            {
                this.strategy = strategy;
            }
            this.drinks = new List<int>();
        }

        public void AddDrink(int cost)
        {
            this.drinks.Add(cost);
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double CountPrice()
        {
            return this.strategy.Sum(this.drinks);
        }
    }
}
