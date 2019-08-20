using System;

namespace HelloWorld.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldMaker helloWorldMaker = new HelloWorldMaker();
            var result = helloWorldMaker.Greetings("Markus");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
