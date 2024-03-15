using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Mx5Miata : RaceCar
    {
        public Mx5Miata()
        {
            Name = "Mx5Miata";
            TopSpeed = 120;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The modified {Name} backfires and shoots flames!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} drifts to a stop and winks its headlights at the audince!!");
           
        }
        public override void StopEngine()
        {
            Console.WriteLine($"Pickle Rick kills the engine and hops out the car to wave at audience");
        }

    }
}
