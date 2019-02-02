using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Races.Models;
using Races.Models.Feeds.Caulfield;

namespace Races.Logic
{
    public class CaulfieldFeed : IFeed
    {
        public RaceTrack GetRaceTrackWithAllRaces(string feed)
        {
            var serializer = new XmlSerializer(typeof(meeting));

            meeting meeting;

            using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(feed)))
            {
                meeting = (meeting) serializer.Deserialize(stream);
            }

            return ConvertToRaceTrackModel(meeting);
        }

        private RaceTrack ConvertToRaceTrackModel(meeting meeting)
        {
            var race = meeting.races.race;

            var horses = race.horses.Select(horse => new Horse
            {
                Name = horse.name,
                Price = race.prices.price.horses.FirstOrDefault(h => h.number == horse.number)?.Price ?? 0
            }).ToList();

            var raceModel = new Race
            {
                Name = race.name,
                Horses = horses
            };

            return new RaceTrack
            {
                Name = "CaulField",
                Races = new List<Race> {raceModel}
            };

        }
    }
}