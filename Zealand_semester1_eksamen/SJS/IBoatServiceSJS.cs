using Zealand_semester1_eksamen.Models;

namespace Zealand_semester1_eksamen.SJS
{
    public interface IBoatServiceSJS
    {
        List<BoatSJS> GetBoats();
        void AddBoat(BoatSJS boat);


        BoatSJS GetBoat(int id);
    }

}
