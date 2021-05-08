using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier n) : base(n)
        {
        }

        public override void SendMessage(string message)
        {
            base.SendMessage(message+" sent to Slack,");
        }
    }
}
