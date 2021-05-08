using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class ProxyDatabase : IDatabase
    {
        private RealDatabase _database;

        public ProxyDatabase(RealDatabase database)
        {
            this._database = database;
        }
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._database.Request();
            }
            LogAccess();
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy checking access");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
