
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Races.Logic;
using Races.Utilities;
using Xunit;

namespace Races.Tests
{
	public class WolferhamptonFeedTest
    {
		[Fact]
		public void RetursTheRaceModelFromTheFeedTest()
		{
			var feed = EmbeddedFeeds.GetFeed("Wolferhampton_Race1.json");

            var wolfFeed = new WolferhamptonFeed();

            var actual = wolfFeed.GetRaceTrackWithAllRaces(feed);

			Assert.Equal("13:45 @ Wolverhampton", actual.Races[0].Name);

            Assert.Equal((decimal)4.4, actual.Races[0].Horses[1].Price);

        }

	}
}
