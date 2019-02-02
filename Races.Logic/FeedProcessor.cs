using System.Collections.Generic;
using System.Linq;
using Races.Models;

namespace Races.Logic
{
    public class FeedProcessor : IFeedProcessor
    {
        private readonly IList<IFeed> feeds;

        public FeedProcessor(IList<IFeed> feeds)
        {
            this.feeds = feeds;
        }

        public IList<RaceTrack> GetAllRacesOrderByPrice()
        {
            var tracks = new List<RaceTrack>();

            foreach (var feed in feeds)
            {
                var track = feed.GetRaceTrackWithAllRaces("");

                foreach (var race in track.Races)
                {
                    race.Horses = OrderHorsesByPriceAsc(race.Horses);
                }

                tracks.Add(track);
            }

            return tracks;
        }

        private IList<Horse> OrderHorsesByPriceAsc(IList<Horse> raceHorses)
        {
            return raceHorses.OrderBy(h => h.Price).ToList();
        }
    }
}
