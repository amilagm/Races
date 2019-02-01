namespace Races.Models.Feeds.CaulField
{
	public  class Participant
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public ParticipantTags Tags { get; set; }
	}
}