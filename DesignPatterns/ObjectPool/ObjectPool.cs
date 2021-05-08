using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DesignPatterns.ObjectPool
{
    class ObjectPool
    {
        private List<SqlConnection> connections = new List<SqlConnection>();

        public SqlConnection GetConnection()
        {
            if (connections.Count == 0)
            {
                return new SqlConnection();
            }
            else
            {
                SqlConnection Vratit = connections[0];
                connections.RemoveAt(0);
                return Vratit;
            }
        }

        public void ReturnConnection(SqlConnection con)
        {
            connections.Add(con);
        }
    }
}
