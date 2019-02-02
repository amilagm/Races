using System;
using System.Collections.Generic;
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
            throw  new NotImplementedException();
        }

    }
}
