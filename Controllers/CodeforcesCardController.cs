using Microsoft.AspNetCore.Mvc;
using MyUhuntCard.Services;
using MyUhuntCard.Views;


namespace MyUhuntCard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CodeforcesCardController : ControllerBase
    {
        private readonly ILogger<CodeforcesCardController> _logger;

        public CodeforcesCardController(ILogger<CodeforcesCardController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{Username}")]
        public async Task<ContentResult> GetAcceptedAsync(string Username)
        {
            CodeforcesAPI service = new CodeforcesAPI();

            CardCodeforces view = new CardCodeforces();

            try
            {
                string accepted = (await service.GetAcceptedAsync(Username)).Value.ToString();

                return base.Content(view.GetCard(Username, accepted), "image/svg+xml");
            }
            catch
            {
                return base.Content(view.GetCard(Username, "Error"), "image/svg+xml");
            }
        }
    }
}
