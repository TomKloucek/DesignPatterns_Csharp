using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Notifier
    {
        public virtual void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
