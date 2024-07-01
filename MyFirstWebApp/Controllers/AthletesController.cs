using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Database;
using MyFirstWebApp.Models;
using MyFirstWebApp.Models.Entities;

namespace MyFirstWebApp.Controllers
{
    public class AthletesController : Controller
    {
        private readonly AppDatabaseContext databaseContext;
        public AthletesController(AppDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext; 
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAthleteVM athleteVM) 
        {
            var athlete = new Athlete
            {
                Name = athleteVM.Name,
                Email = athleteVM.Email,
                PhoneNumber = athleteVM.PhoneNumber,
                Injured = athleteVM.Injured,
            };
            await databaseContext.Athletes.AddAsync(athlete);
            await databaseContext.SaveChangesAsync();
            return View();
        }
    }
}
