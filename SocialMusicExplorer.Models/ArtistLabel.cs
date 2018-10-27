using Postulate.Lite.Core.Attributes;

namespace SocialMusicExplorer.Models
{
	public class ArtistLabel : BaseTable
	{
		[References(typeof(Artist))]
		[PrimaryKey]
		public int ArtistId { get; set; }

		[References(typeof(Label))]
		[PrimaryKey]
		public int LabelId { get; set; }

		public int Votes { get; set; }
	}
}