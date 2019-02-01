using System;
using System.Collections.Generic;

namespace Races.Models.Feeds.CaulField
{
	public  class RawData
	{
		public string FixtureName { get; set; }
		public string Id { get; set; }
		public DateTimeOffset StartTime { get; set; }
		public long Sequence { get; set; }
		public RawDataTags Tags { get; set; }
		public List<Market> Markets { get; set; }
		public List<Participant> Participants { get; set; }
	}
}