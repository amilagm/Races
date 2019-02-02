﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            var serviceProvider = BuildServiceProvider();

            var processor = serviceProvider.GetService<IFeedProcessor>();

            var tracks = processor.GetAllRacesOrderByPrice();

            foreach (var track in tracks)
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

            Console.ReadLine();
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
