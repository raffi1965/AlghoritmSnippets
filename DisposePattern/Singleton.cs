using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposePattern
{
    class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new Object();

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            lock (syncRoot)
            {
                if (instance == null)
                    instance = new Singleton();
            }

            return instance;
        }
    }
}
