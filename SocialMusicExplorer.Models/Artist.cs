using Postulate.Lite.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace SocialMusicExplorer.Models
{
	public class Artist : BaseTable
	{
		[PrimaryKey]
		[MaxLength(100)]
		public string Name { get; set; }

		/// <summary>
		/// Artist's official home page
		/// </summary>
		[MaxLength(100)]
		public string ArtistUrl { get; set; }

		/// <summary>
		/// Wikipedia or other info URL
		/// </summary>
		[MaxLength(100)]
		public string InfoUrl { get; set; }
	}
}