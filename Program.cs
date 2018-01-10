using System;
using Newtonsoft.Json;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "abc".Remove(1);
            Console.WriteLine(text);
            var jsonText = JsonConvert.SerializeObject(new { key1 = text});
            Console.WriteLine(jsonText);
            Console.WriteLine("Hello World!");
        }
    }
}
