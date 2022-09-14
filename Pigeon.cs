using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdTracker
{
    internal class Pigeon : Bird
    {
        public const double MAXIMUM = 3.0;
        public const double MINIMUM = 1.0;
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    eggs[i] = new BrokenEgg("white");
                }
                else
                {
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * (MAXIMUM - MINIMUM) + MINIMUM, "white");

                }
            }
            return eggs;
        }
    }
}
