using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDemo
{
    public sealed class Singleton
    {
        private static Singleton singleton;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if(singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
    public enum S
    {
        
    }
}
