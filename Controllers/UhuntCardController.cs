using Microsoft.AspNetCore.Mvc;
using MyUhuntCard.Services;
using MyUhuntCard.Views;

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
        public async Task<ContentResult> GetUserIDAsync(string Username)
        {
            try
            {
                UhuntAPI response = new UhuntAPI();

                string UserID = (await response.GetUserIDAsync(Username)).Value;
                Card myCard = new Card();
                return base.Content(myCard.GetCard((await response.GetAcceptedAsync(UserID)).Value.ToString(), Username), "image/svg+xml");
            }
            catch
            {
                return base.Content("Ocorreu um erro", "text/plain");
            }
        }
    }
}
