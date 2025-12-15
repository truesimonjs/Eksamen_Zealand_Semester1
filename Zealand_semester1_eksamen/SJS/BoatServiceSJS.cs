using Zealand_semester1_eksamen.Models;

namespace Zealand_semester1_eksamen.SJS
{
    public class BoatServiceSJS : IBoatServiceSJS
    {
        public List<BoatSJS> boats;
        public BoatServiceSJS() 
        {
            boats = MockBoat.Boats;
        }
        public void AddBoat(BoatSJS boat)
        {
            boats.Add(boat);
        }

        public List<BoatSJS> GetBoats()
        {
            return boats;

        }
    }
}
