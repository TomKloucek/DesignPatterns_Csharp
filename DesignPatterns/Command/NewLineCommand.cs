using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class NewLineCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine();
        }
    }
}
