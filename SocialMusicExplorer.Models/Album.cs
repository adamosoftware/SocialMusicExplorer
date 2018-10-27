using Postulate.Lite.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SocialMusicExplorer.Models
{
	public class Album : BaseTable
	{
		[References(typeof(Artist))]
		[PrimaryKey]
		public int ArtistId { get; set; }

		[PrimaryKey]
		[MaxLength(100)]
		public string Title { get; set; }

		public int Year { get; set; }

		/// <summary>
		/// Wikipedia or other info URL
		/// </summary>
		[MaxLength(100)]
		public string InfoUrl { get; set; }
	}
}