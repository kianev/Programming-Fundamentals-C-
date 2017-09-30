using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FF = long.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());

          
                double usefulPics = Math.Ceiling((double)N * ((double)FF / 100));

                double filteredPicsTimeSec = N * FT;
                double totalTimeSec = usefulPics * UT + filteredPicsTimeSec;

                TimeSpan timespan = TimeSpan.FromSeconds(totalTimeSec);
                long day = timespan.Days;
                long hour = timespan.Hours;
                long min = timespan.Minutes;
                long sec = timespan.Seconds;

            
                string answer = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}", day, hour, min, sec);

                Console.WriteLine(answer);
        }
    }
}
