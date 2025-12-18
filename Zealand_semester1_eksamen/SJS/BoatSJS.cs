using System.Numerics;

namespace Zealand_semester1_eksamen.Models
{
    public class BoatSJS
    {
        public int Id { get; set; }
        //public string Type { get; set; }
        //public string Model { get; set; }
        public string Name { get; set; }
        public List<string> MaintenanceLogs { get; set; } = new List<string>();
        public int SailNumber { get; set; }
        public Vector3 Dimensions 
        { 
            
            get
            {
                return new Vector3(Width, Height, Length);
            } 
        }
        public float Width {  get; set; }
        public float Height { get; set; }
        public float Length { get; set; }

        public int Year { get; set; }
        private static int currentId;
        public BoatSJS()
        {
            Id = currentId;
            currentId++;
            MaintenanceLogs = new List<string>();
        }
        public BoatSJS (string name, int sailNumber, Vector3 dimensions, int year)
        {
            Id = currentId;
            currentId++;
            Name = name;
            SailNumber = sailNumber;
            Width = dimensions.X;
            Height = dimensions.Y;
            Length = dimensions.Z;
            Year = year;
            MaintenanceLogs = new List<string>();
        }
    }
}
