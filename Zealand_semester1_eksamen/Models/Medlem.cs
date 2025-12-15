namespace Zealand_semester1_eksamen.Models
{
    public class Medlem
    {
        public int MedlemId { get; set; }
        public string Navn { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString()
        {
            return $"{MedlemId}: {Navn} - {Email}";
        }
    }
}




