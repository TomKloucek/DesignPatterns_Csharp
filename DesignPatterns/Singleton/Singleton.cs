using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        public Singleton() { }

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
