using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Races.Logic;
using Races.Utilities;
using Xunit;

namespace Races.Tests
{
	public class CaulfieldFeedTest
    {
		[Fact]
		public void RetursTheRaceModelFromTheFeedTest()
		{
			var feed = EmbeddedFeeds.GetFeed("Caulfield_Race1.xml");

            var caulFeed = new CaulfieldFeed();

            var actual = caulFeed.GetRaceTrackWithAllRaces(feed);

			Assert.Equal("Evergreen Turf Plate", actual.Races[0].Name);

		}

	}
}
