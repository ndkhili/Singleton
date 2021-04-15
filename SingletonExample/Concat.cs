using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
    public sealed class Concat
    {
        private Concat()
        {
        }

        private static readonly object padlock = new object();

        private static Concat instance = null;
        
        public static Concat Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Concat();
                    }
                    return instance; 
                }
            }
        }

        public string Word1 { get; set; }

        public string Word2 { get; set; }

        public string Concatenate()
        {
            return Word1 + Word2;
        }
    }
}
