using System;
namespace MagicVila_VillaMagic.Models.Dto
{
	public class VilaDto
	{
		public int Id { get; set; }

		public required string Name { get; set; }

		public DateTime CreatedDate { get; set; }
	}
}

