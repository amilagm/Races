using System.Collections.Generic;
using Races.Models;

namespace Races.Logic
{
    public interface IFeedProcessor
    {
        IList<RaceTrack> GetAllRacesOrderByPrice();
    }
}