using Postulate.Lite.Core.Attributes;
using Postulate.Lite.Core.Extensions;
using Postulate.Lite.SqlServer;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SocialMusicExplorer.Models
{
	public class Label : BaseTable
	{
		[MaxLength(50)]
		[PrimaryKey]
		public string Name { get; set; }

		public static DataTable GetSeedData()
		{
			return new Label[]
			{
				new Label() { Name = "60s", CreatedBy = "system" },
				new Label() { Name = "70s", CreatedBy = "system" },
				new Label() { Name = "90s", CreatedBy = "system" },
				new Label() { Name = "00s", CreatedBy = "system" }
			}.ToDataTable(new SqlServerIntegrator(), excludeIdentity: true);

		}
	}
}