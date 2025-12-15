using System.Numerics;

namespace Zealand_semester1_eksamen.Models
{
    public class Boat
    {
        public int Id { get; set; }
        //public string Type { get; set; }
        //public string Model { get; set; }
        public string Name { get; set; }
        public int SailNumber { get; set; }
        public Vector3 Dimensions { get; set; }
        public int Year { get; set; }


        public Boat (int id, string name, int sailNumber, Vector3 dimensions, int year)
        {
            Id = id;
            Name = name;
            SailNumber = sailNumber;
            Dimensions = dimensions;
            Year = year;
        }
    }
}
