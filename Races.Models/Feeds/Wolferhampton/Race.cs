using System;

namespace Races.Models.Feeds.CaulField
{
	/// <summary>
	/// Auto genrated using https://app.quicktype.io
	/// </summary>
	public class Race
	{
		public string FixtureId { get; set; }
		public DateTimeOffset Timestamp { get; set; }
		public RawData RawData { get; set; }
	}
}