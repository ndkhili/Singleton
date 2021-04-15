using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Concat.Instance.Word1 = "Test";
            Concat.Instance.Word2 = "Engie";

            Console.WriteLine("Concatenate : " + Concat.Instance.Concatenate());
        }
    }
}
