namespace Races.Models.Feeds.Caulfield
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public  class meeting
	{

		private string dateField;

		private string meetingTypeField;

		private meetingTrack trackField;

		private uint meetingidField;

		private meetingRaces racesField;

		/// <remarks/>
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}

		/// <remarks/>
		public string MeetingType
		{
			get
			{
				return this.meetingTypeField;
			}
			set
			{
				this.meetingTypeField = value;
			}
		}

		/// <remarks/>
		public meetingTrack track
		{
			get
			{
				return this.trackField;
			}
			set
			{
				this.trackField = value;
			}
		}

		/// <remarks/>
		public uint Meetingid
		{
			get
			{
				return this.meetingidField;
			}
			set
			{
				this.meetingidField = value;
			}
		}

		/// <remarks/>
		public meetingRaces races
		{
			get
			{
				return this.racesField;
			}
			set
			{
				this.racesField = value;
			}
		}
	}
}