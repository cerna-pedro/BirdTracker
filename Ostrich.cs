using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdTracker
{
    internal class Ostrich: Bird
    {
        public const double MAXIMUM = 13.0;
        public const double MINIMUM = 12.0;
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Randomizer.NextDouble() * (MAXIMUM-MINIMUM) + MINIMUM, "speckled");
            }
            return eggs;
        }
    }
}
