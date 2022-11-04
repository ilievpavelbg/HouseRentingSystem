using HouseRentingSystem.Core.Models.Agents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult Become()
        {
            var model = new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeAgentFormModel model)
        {
            

            return RedirectToAction(nameof(HousesController.All), "Houses");
        }
    }
}
