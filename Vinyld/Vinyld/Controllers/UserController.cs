using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vinyld.Models;

namespace Vinyld.Controllers
{
    public class UserController : Controller
    {
        VinylDbContext dbContext = new VinylDbContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        [HttpGet("{artist}")]
        public User GetArtist(string artist)
        {
            return dbContext.Users.FirstOrDefault(a => a.Artist == artist);
        }
    }
}
