using System.Collections.Generic;
using System.Linq;
using Zealand_semester1_eksamen.Models;

namespace Zealand_semester1_eksamen.Services
{
    public class MedlemFil
    {
        // Static list = shared memory (replaces database)
        private static List<Medlem> medlemmer = new List<Medlem>();

        public static List<Medlem> GetAll()
        {
            return medlemmer;
        }

        public static void AddMedlem(Medlem m)
        {
            medlemmer.Add(m);
        }

        public static void DeleteMedlem(int id)
        {
            var m = medlemmer.FirstOrDefault(x => x.MedlemId == id);
            if (m != null)
            {
                medlemmer.Remove(m);
            }
        }

        public static Medlem? GetById(int id)
        {
            return medlemmer.FirstOrDefault(x => x.MedlemId == id);
        }

        public static void UpdateMedlem(int id, string nytNavn, string nyEmail)
        {
            var m = GetById(id);
            if (m != null)
            {
                m.Navn = nytNavn;
                m.Email = nyEmail;
            }
        }
    }
}

