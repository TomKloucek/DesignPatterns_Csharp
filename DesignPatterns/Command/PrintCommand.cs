using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class PrintCommand : ICommand
    {
        private string Text {get; set;}
        public PrintCommand(string text)
        {
            this.Text = text;
        }
        public void Execute()
        {
            Console.WriteLine(Text);
        }
    }
}
