using System;
using MagicVila_VillaMagic.Data;
using MagicVila_VillaMagic.Models;
using MagicVila_VillaMagic.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVila_VillaMagic.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VillaAPIController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<VilaDto> GetVillas()
		{
			return VilaStore.vilaList;

		}

        [HttpGet("id")]
        public VilaDto GetVila(int id)
		{
			return VilaStore.vilaList.FirstOrDefault(u => u.Id == id);
		}
	}
}

