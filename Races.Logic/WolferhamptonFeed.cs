using System.Collections.Generic;
using System.Linq;
using Races.Models;
using Newtonsoft.Json;

namespace Races.Logic
{
    public class WolferhamptonFeed : IFeed
    {
        public RaceTrack GetRaceTrackWithAllRaces(string feed)
        {
            var race = JsonConvert.DeserializeObject<Models.Feeds.CaulField.Race>(feed);

            return ConvertToRaceTrackModel(race);
        }

        private RaceTrack ConvertToRaceTrackModel(Models.Feeds.CaulField.Race race)
        {

            var horses = race.RawData.Participants.Select(horse => new Horse
            {
                Name = horse.Name,
                Price = (decimal?)race.RawData.Markets.SelectMany(m => m.Selections).FirstOrDefault(s => s.Tags.Name == horse.Name)?.Price ?? 0
            }).ToList();

            var raceModel = new Race
            {
                Name = race.RawData.FixtureName,
                Horses = horses
            };

            return new RaceTrack
            {
                Name = "Wolferhampton",
                Races = new List<Race> {raceModel}
            };

        }
    }
}