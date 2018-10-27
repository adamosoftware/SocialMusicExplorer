using Postulate.Lite.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SocialMusicExplorer.Models
{
	public class SongLink : BaseTable
	{
		/// <summary>
		/// Public link to song, for example on YouTube, Soundcloud, or some other source
		/// </summary>
		[MaxLength(255)]
		[PrimaryKey]
		public string Url { get; set; }

		[References(typeof(Song))]
		public int SongId { get; set; }
	}
}