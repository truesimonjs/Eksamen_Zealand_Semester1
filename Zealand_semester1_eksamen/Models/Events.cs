using System;

namespace Zealand_semester1_eksamen.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string Lokation { get; set; }
        public DateTime Dato { get; set; }

        // Tom constructor (nødvendig for at formularer virker)
        public Event()
        {
        }

        // Constructor til når vi opretter test-data
        public Event(int id, string navn, string beskrivelse, string lokation, DateTime dato)
        {
            Id = id;
            Navn = navn;
            Beskrivelse = beskrivelse;
            Lokation = lokation;
            Dato = dato;
        }
    }
}