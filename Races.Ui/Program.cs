using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Races.Logic;
using Races.Utilities;

namespace Races.Ui
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serviceProvider = BuildServiceProvider();

            var processor = serviceProvider.GetService<IFeedProcessor>();

            var races = processor.GetAllRacesOrderByPrice();
        }


        private static ServiceProvider BuildServiceProvider()
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IFeedProcessor,FeedProcessor>();

            collection.AddTransient(FeedFactory.GetAllFeeds);

            return collection.BuildServiceProvider();
            
        }
    }
}
