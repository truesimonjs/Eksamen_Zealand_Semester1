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
                    new("boat1",123,Vector3.Zero,2003),
                    new("boat2",124,Vector3.One,2004)

                };
            }
        }
    }
}
