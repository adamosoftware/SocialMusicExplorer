using Postulate.Lite.Core.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMusicExplorer.Models
{
	[Table("AspNetUsers")]
	[Identity(nameof(UserId), constraintName: "U_AspNetUsers_UserId")]
	public class UserProfile
	{
		public int UserId { get; set; }

		[Required]
		public string UserName { get; set; }

		[DefaultExpression("0")]
		public int TimeZoneOffset { get; set; }
	}
}