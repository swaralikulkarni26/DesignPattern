using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.getInstance();
            logger.Log("This is first Logger Instance");
            logger.Log("This is second instance");
        }
    }
}
