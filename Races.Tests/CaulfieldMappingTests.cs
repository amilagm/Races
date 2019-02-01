using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Races.Utilities;
using Xunit;

namespace Races.Tests
{
	public class CaulfieldMappingTests
	{
		[Fact]
		public void ClassesMatchesTheFeedTest()
		{
			var feed = EmbeddedFeeds.GetFeed("Caulfield_Race1.xml");

			var serializer = new XmlSerializer(typeof(meeting));

			meeting meeting;

			using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(feed)))
			{
				meeting = (meeting) serializer.Deserialize(stream);
			}

			var actual = meeting.races.race.horses.First(h => h.id == 872699).name;

			const string expected = "Advancing";

			Assert.Equal(expected, actual);

		}

	}
}
