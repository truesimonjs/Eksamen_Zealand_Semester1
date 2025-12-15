using System.Numerics;
using Zealand_semester1_eksamen.Models;

namespace Zealand_semester1_eksamen.SJS
{
    public class MockBoat
    {
        public static List<BoatSJS> Boats
        {
            get
            {
                return new List<BoatSJS>()
                {
                    new(1,"boat1",123,Vector3.Zero,2003),
                    new(2,"boat2",124,Vector3.One,2004)

                };
            }
        }
    }
}
