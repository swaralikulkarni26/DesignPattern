using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Logger
    {
        private static Logger instance;
        private  Logger()
        {

        }

       public static Logger getInstance()
        {
           
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

            }
            return instance;
        }

       public void Log(string msg)
        {
            Console.WriteLine($"{ DateTime.Now} { msg}");
        }
           

    }
}
