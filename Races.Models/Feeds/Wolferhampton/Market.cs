using System.Collections.Generic;

namespace Races.Models.Feeds.CaulField
{
	public  class Market
	{
		public string Id { get; set; }
		public List<Selection> Selections { get; set; }
		public MarketTags Tags { get; set; }
	}
}