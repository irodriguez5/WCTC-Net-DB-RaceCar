using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars; 

namespace RaceTrack.RaceTrack.Drivers
{
   public class PickleRick : Driver
    {
      public PickleRick(RaceCar car) : base(car)
        {
         Name = "Pickle Rick";
         SkillLevel = 20;
      }

      public override void Drive()
        {
         Car.Accelerate(SkillLevel);
      }
        public override void StopEngine()
        {
            base.StopEngine();
        }
    }
}
