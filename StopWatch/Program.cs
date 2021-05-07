using System;

namespace StopWatch
{
    partial class Program
    {

        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            stopWatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopWatch.Stop();
            //stopWatch.Start();
            //System.Threading.Thread.Sleep(2000);
             //stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration());

        }
    }
}
