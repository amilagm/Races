using System;
using System.Collections.Generic;
using Races.Logic;

namespace Races.Utilities
{
    public  static  class FeedFactory
    {
        public static IList<IFeed> GetAllFeeds(IServiceProvider serviceProvider)
        {
            //TODO dynamically control the feeds using confid

            var caulFeed = new CaulfieldFeed(EmbeddedFeeds.GetFeed("Caulfield_Race1.xml"));

            var wolfFeed = new WolferhamptonFeed(EmbeddedFeeds.GetFeed("Wolferhampton_Race1.json"));

            return new List<IFeed>{caulFeed, wolfFeed};
        }
    }
}
