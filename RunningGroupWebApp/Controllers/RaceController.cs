using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Interfaces;
using RunningGroupWebApp.Data;
using RunningGroupWebApp.Models;

namespace RunningGroupWebApp.Controllers
{
    public class RaceController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IRaceRepo _raceRepo;
        public RaceController( IRaceRepo raceRepo)
        {            
            _raceRepo = raceRepo;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await _raceRepo.GetAllRaces();
            return View(races);
        }
        public async Task<IActionResult> Detail(int id)
        {
            //Race race = _context.Races.Include(a => a.Address).FirstOrDefault(r => r.Id == id);
            Race race = await _raceRepo.GetRaceById(id);
            return View(race);
        }
    }
}
