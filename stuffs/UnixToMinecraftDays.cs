using System;

namespace UnixToMinecraftDays
{
    class Program
    {
        static void Main(string[] args)
        {
            // My first ever fully self-made program
            long ans = Convert.ToInt32(Console.ReadLine());
            long curr = DateTimeOffset.Now.ToUnixTimeSeconds();
            long time = curr - ans;
            long timeAsMins = time / 60;
            long minecraftDays = timeAsMins / 20;
            Console.WriteLine(minecraftDays);
        }
    }
}
