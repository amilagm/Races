using Races.Models;

namespace Races.Logic
{
    public interface IFeed
    {
        RaceTrack GetRaceTrackWithAllRaces();
    }
}