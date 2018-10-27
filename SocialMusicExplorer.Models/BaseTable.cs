using Postulate.Lite.Core.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace SocialMusicExplorer.Models
{
	[Identity(nameof(Id), IdentityPosition.FirstColumn)]
	public abstract class BaseTable
	{
		public int Id { get; set; }

		[MaxLength(50)]
		[Required]
		public string CreatedBy { get; set; }

		public DateTime DateCreated { get; set; } = DateTime.UtcNow;

		[MaxLength(50)]
		public string ModifiedBy { get; set; }

		public DateTime? DateModified { get; set; }
	}
}