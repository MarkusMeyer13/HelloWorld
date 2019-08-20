using System;

namespace HelloWorld
{
    public class HelloWorldMaker
    {
        public string Greetings(string name)
        {
            var result = $"Hello World,{name}";
            return result;
        }
    }
}
