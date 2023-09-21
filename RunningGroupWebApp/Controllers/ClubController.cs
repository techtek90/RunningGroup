using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Interfaces;
using RunningGroupWebApp.Data;
using RunningGroupWebApp.Models;

namespace RunningGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IClubRepo _clubRepo;
        public ClubController(AppDbContext context, IClubRepo clubRepo)
        {
            _context = context;
            _clubRepo = clubRepo;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepo.GetAllClub();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            //Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            Club club = await _clubRepo.GetClubById(id);
            return View(club);
        }
    }
}
