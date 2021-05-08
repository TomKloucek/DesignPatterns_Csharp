using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class BaseDecorator : Notifier
    {
        private Notifier wrappe;

        public BaseDecorator(Notifier n)
        {
            this.wrappe = n;
        }

        public override void SendMessage(string message)
        {
            wrappe.SendMessage(message);
        }
    }
}
