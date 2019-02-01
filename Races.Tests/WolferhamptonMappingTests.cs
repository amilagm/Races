using System.Linq;
using Newtonsoft.Json;
using Races.Models.Feeds.CaulField;
using Races.Utilities;
using Xunit;

namespace Races.Tests
{
    public class WolferhamptonMappingTests
    {
        [Fact]
        public void ClassesMatchesTheFeedTest()
        {
	        var feed = EmbeddedFeeds.GetFeed("Wolferhampton_Race1.json");

	        var race = JsonConvert.DeserializeObject<Race>(feed);

	        var actual = race.RawData.Participants.First(p => p.Id == 2).Name;

	        const string expected = "Fikhaar";

			Assert.Equal(expected, actual);

        }

	}
}
