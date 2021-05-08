using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton getting instance
            Singleton.Singleton s = Singleton.Singleton.getInstance();

            // Factory method
            Factory.TransportFactory tovarna = new Factory.TransportFactory();
            Factory.ITransport auto = tovarna.Vytvor(255);
            Factory.ITransport lod = tovarna.Vytvor(250,"Ship");
            auto.Deliver();
            lod.Deliver();

            // Object pool
            ObjectPool.ObjectPool pool = new ObjectPool.ObjectPool();
            SqlConnection connection = pool.GetConnection();
            // work with connection
            pool.ReturnConnection(connection);

            // Iterator
            var collection = new Iterator.WordsCollection();
            collection.AddItem("A");
            collection.AddItem("B");
            collection.AddItem("C");
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
            // reverse
            collection.reverseDirection();
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }

            // Command
            List<Command.ICommand> commands = new List<Command.ICommand>();
            commands.Add(new Command.PrintCommand("Prvni radek"));
            commands.Add(new Command.NewLineCommand());
            commands.Add(new Command.PrintCommand("Radek po newLine"));
            foreach(var command in commands)
            {
                command.Execute();
            }

            // Strategy
            Strategy.Cashdesk cashdesk = new Strategy.Cashdesk();
            cashdesk.AddDrink(45);
            cashdesk.AddDrink(25);
            cashdesk.AddDrink(15);
            Console.WriteLine("Classic price :"+cashdesk.CountPrice());
            Strategy.IStrategy happy = new Strategy.HappyHourStrategy();
            cashdesk.ChangeStrategy(happy);
            Console.WriteLine("Happy hour price :" + cashdesk.CountPrice());

            //Decorator
            Decorator.Notifier stack = new Decorator.Notifier();
            stack = new Decorator.WhatsAppDecorator(stack);
            stack = new Decorator.SlackDecorator(stack);
            stack.SendMessage("Zprava");

            // Flyweight
            string document = "AAA";
            char[] chars = document.ToCharArray();
            Flyweight.CharacterFactory factory = new Flyweight.CharacterFactory();
            int pointSize = 10;
            foreach(char c in chars)
            {
                pointSize++;
                Flyweight.Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            // Proxy
            Proxy.RealDatabase database = new Proxy.RealDatabase();
            Proxy.ProxyDatabase proxy = new Proxy.ProxyDatabase(database);
            proxy.Request();

        }
    }
}
