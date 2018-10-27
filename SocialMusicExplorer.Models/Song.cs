using Postulate.Lite.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SocialMusicExplorer.Models
{
	public class Song : BaseTable
	{
		[References(typeof(Album))]
		public int AlbumId { get; set; }

		[MaxLength(100)]
		[Required]
		public string Title { get; set; }		
	}
}