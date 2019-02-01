using System;
using System.Collections.Generic;

namespace Races.Models
{
    public class Race
    {
	    public string Name { get; set; }
	    public Guid Id { get; set; }
	    public IList<Horse> Horses { get; set; }
	  

	}
}
