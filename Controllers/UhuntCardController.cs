using Microsoft.AspNetCore.Mvc;
using MyUhuntCard.Models;
using MyUhuntCard.Services;

namespace MyUhuntCard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UhuntCardController: ControllerBase
    {
   
        private readonly ILogger<UhuntCardController> _logger;

        public UhuntCardController(ILogger<UhuntCardController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{Username}")]
        public async Task<Response<int>> GetUserIDAsync(string Username)
        {
            UhuntAPI response = new UhuntAPI();

            string UserID = (await response.GetUserIDAsync(Username)).Value;

            return await response.GetAcceptedAsync(UserID);
        }
    }
}
