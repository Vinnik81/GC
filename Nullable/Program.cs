using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // int @string = 10;
            //int a = null;
            //Nullable<int> a = null;
            //int? a = null;
            string name = null; //= "Vladimir";
            string result = name ?? "No name" ?? "Too";

            // Console.WriteLine($"Name состоит из: {result?.Length} ");
            Console.WriteLine($"Name состоит из: {result.Length} ");
        }
    }
}
