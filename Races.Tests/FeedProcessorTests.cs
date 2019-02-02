using System.Collections.Generic;
using System.Linq;
using Moq;
using Races.Logic;
using Races.Models;
using Xunit;
using Race = Races.Models.Race;

namespace Races.Tests
{
    public class FeedProcessorTests
    {
        [Fact]
        public void GetAllRacesOrderByPriceTest()
        {
            var feedMock1 = new Mock<IFeed>();

            feedMock1.Setup(f => f.GetRaceTrackWithAllRaces()).Returns(
                new RaceTrack
                {
                    Name = "Caulfield",
                    Races = new List<Race>
                    {
                        new Race
                        {
                            Name = "race 1",
                            Horses = new List<Horse>
                                {new Horse {Name = "2", Price = 2}, new Horse {Name = "1", Price = 1}}
                        }
                    }
                });

            var feedMock2 = new Mock<IFeed>();

            feedMock2.Setup(f => f.GetRaceTrackWithAllRaces()).Returns(
                new RaceTrack
                {
                    Name = "Wolferhampton",
                    Races = new List<Race>
                    {
                        new Race
                        {
                            Name = "race 3",
                            Horses = new List<Horse>
                                {new Horse {Name = "4", Price = 4}, new Horse {Name = "3", Price = 3}}
                        }
                    }
                });

            var processor = new FeedProcessor(new List<IFeed>{feedMock1.Object, feedMock2.Object});
            
            var result = processor.GetAllRacesOrderByPrice();

            var caulHorses = result.Where(t => t.Name == "Caulfield").SelectMany(t => t.Races[0].Horses).ToList();

            var wolfHorses = result.Where(t => t.Name == "Wolferhampton").SelectMany(t => t.Races[0].Horses).ToList();

            Assert.Equal(2, caulHorses.Count);
            Assert.Equal("1", caulHorses[0].Name);
            Assert.Equal("2", caulHorses[1].Name);

            Assert.Equal(2, wolfHorses.Count);
            Assert.Equal("3", wolfHorses[0].Name);
            Assert.Equal("4", wolfHorses[1].Name);


        }

    }
}
