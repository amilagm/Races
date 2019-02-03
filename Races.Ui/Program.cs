using System;
using Microsoft.Extensions.DependencyInjection;
using Races.Logic;
using Races.Utilities;

namespace Races.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Race details");

            Console.WriteLine("========================================================");

            try
            {
                var serviceProvider = BuildServiceProvider();

                var processor = serviceProvider.GetService<IFeedProcessor>();

                foreach (var track in processor.GetAllRacesOrderByPrice())
                {
                    Console.WriteLine($"Race track: {track.Name}");

                    foreach (var race in track.Races)
                    {
                        Console.WriteLine($"Race: {race.Name}");

                        Console.WriteLine("Horses");

                        foreach (var horse in race.Horses)
                        {
                            Console.WriteLine($"\t {horse.Name}");
                        }
                    }
                }

                Console.WriteLine("========================================================");

            }
            catch (Exception e)
            {
                //TODO Log it
                Console.WriteLine("An error occured. Please press enter to exit");
            }

            Console.ReadLine();
        }


        private static ServiceProvider BuildServiceProvider()
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IFeedProcessor, FeedProcessor>();

            collection.AddTransient(FeedFactory.GetAllFeeds);

            return collection.BuildServiceProvider();

        }
    }
}
