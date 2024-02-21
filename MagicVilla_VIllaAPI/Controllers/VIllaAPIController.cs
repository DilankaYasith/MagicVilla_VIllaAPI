using MagicVilla_VIllaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VIllaAPI.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VIllaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id=1,Name="Pool View"},
                new Villa{Id=2,Name="Beach View"}
            };
        }
    }
}
