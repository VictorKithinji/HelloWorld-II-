using System;

namespace HelloWorld_II_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "MarkKithinji";
            int makeUnique = 2221;
            string mailServer = ("@outlook");
            string domain = (".com");
            var Email = (name+makeUnique+mailServer+domain);
            Console.WriteLine(Email);
        }
    }
}
