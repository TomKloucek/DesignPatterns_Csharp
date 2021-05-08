using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class WhatsAppDecorator : BaseDecorator
    {
        public WhatsAppDecorator(Notifier n) : base(n)
        {
        }

        public override void SendMessage(string message)
        {
            base.SendMessage(message + " sent to WhatsApp,");
        }
    }
}
