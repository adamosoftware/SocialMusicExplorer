using Postulate.Lite.Core.Attributes;

namespace SocialMusicExplorer.Models
{
	public class SongLinkLabel : BaseTable
	{
		[References(typeof(Song))]
		[PrimaryKey]
		public int SongLinkId { get; set; }

		[References(typeof(Label))]
		[PrimaryKey]
		public int LabelId { get; set; }

		public int Votes { get; set; }
	}
}