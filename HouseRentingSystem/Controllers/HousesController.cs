using HouseRentingSystem.Core.Models.Houses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class HousesController : Controller
    {
        [HttpGet]
        public IActionResult All()
        {
            var model = new AllHousesQueryModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult All(AllHousesQueryModel model)
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Mine()
        {
            var model = new AllHousesQueryModel();

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Details(int Id)
        {
            var model = new HouseDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            var model = new HouseFormModel();

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(HouseFormModel model)
        {

            return RedirectToAction(nameof(Details), new {Id = "1"});
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int Id)
        {
            var model = new HouseFormModel();

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int Id, HouseFormModel model)
        {

            return RedirectToAction(nameof(Details), new { Id = "1" });
        }


        [HttpPost]
        [Authorize]
        public IActionResult Delete(HouseFormModel model)
        {

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Rent(int Id)
        {

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Leave(int Id)
        {

            return RedirectToAction(nameof(Mine));
        }
    }
}
