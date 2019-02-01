using System;
using System.Collections.Generic;

namespace Races.Models
{
    public class RaceTrack
    {
	    public string Name { get; set; }
	    public Guid Id { get; set; }
		public  IList<Race> Races { get; set; }
	}
}
