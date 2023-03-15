using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User07Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            List<string> time = new List<string>();
            int i = 0;

            while (beginWorkingTime < endWorkingTime && beginWorkingTime.Add(new TimeSpan(0, consultationTime, 0)) <= endWorkingTime)
            {
                TimeSpan beginWorkingTimeThree = beginWorkingTime + TimeSpan.FromMinutes(consultationTime);

                if (i < startTimes.Length && beginWorkingTimeThree > startTimes[i])
                {
                    beginWorkingTime = startTimes[i] + TimeSpan.FromMinutes(durations[i]);
                    i++;
                    continue;
                }

                time.Add($"{beginWorkingTime.ToString("hh':'mm")} - {beginWorkingTimeThree.ToString("hh':'mm")}");
                beginWorkingTime += TimeSpan.FromMinutes(consultationTime);
            }

            return time.ToArray();
        }
    }
}
