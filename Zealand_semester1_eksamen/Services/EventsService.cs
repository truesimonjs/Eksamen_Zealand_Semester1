using System;
using System.Collections.Generic;
using Zealand_semester1_eksamen.Models;

namespace Zealand_semester1_eksamen.Services
{
    public class EventService
    {
        // Listen der holder vores events
        private List<Event> _events;

        public EventService()
        {
            _events = new List<Event>();
            // Vi putter lidt falsk data i, så vi kan se noget med det samme (hardcoded fordi vi har ikke databaser)
            _events.Add(new Event(1, "Standerhejsning", "Vi hejser flaget", "Havnen", DateTime.Now.AddDays(10)));
            _events.Add(new Event(2, "Grillfest", "Pølser og sodavand", "Klubhuset", DateTime.Now.AddDays(20)));
            _events.Add(new Event(3, "Generalforsamling", "Årligt møde", "Mødelokalet", DateTime.Now.AddDays(30)));
            _events.Add(new Event(4, "Fælles kanotur", "Kom med til søen!", "Søen", DateTime.Now.AddDays(40)));
        }

        //Hent alle events
        public List<Event> GetEvents()
        {
            return _events;
        }

        //Tilføj event
        public void AddEvent(Event nyEvent)
        {
            // Vi skal finde det højeste ID manuelt med en løkke
            int maxId = 0;
            foreach (Event e in _events)
            {
                if (e.Id > maxId)
                {
                    maxId = e.Id;
                }
            }

            // Det nye ID er det højeste vi fandt + 1
            nyEvent.Id = maxId + 1;

            _events.Add(nyEvent);
        }

        // Søgefunktion/filtrering af events 
        public List<Event> SearchEvents(string søgeord)
        {
            List<Event> fundneEvents = new List<Event>();

            foreach (Event e in _events)
            {
                // Vi tjekker om navnet indeholder søgeordet
                // Vi laver alt om til små bogstaver (ToLower) så det ikke betyder noget om man skriver stort eller småt
                if (e.Navn.ToLower().Contains(søgeord.ToLower()))
                {
                    fundneEvents.Add(e);
                }
            }

            return fundneEvents;
        }
        
    }
}