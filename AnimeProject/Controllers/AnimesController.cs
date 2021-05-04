using AnimeProject.Data;
using AnimeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeProject.Controllers

{
    [Route("[Controller]")]
    public class AnimesController : Controller
    {
        private ApplicationDbContext dbContext;
        public AnimesController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        //Read
        public IActionResult Index()
        {
            var allAnimes = dbContext.Animes.ToList();
            return View(allAnimes);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var animeById = dbContext.Animes.FirstOrDefault(c => c.ID == id);
            return View(animeById);
        }




        //Update 
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var animeById = dbContext.Animes.FirstOrDefault(c => c.ID == id);
            return View(animeById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Anime anime, int id)
        {
            var animeToUpdate = dbContext.Animes.FirstOrDefault(c => c.ID == id);
            animeToUpdate.Name = anime.Name;

            animeToUpdate.Episodes = anime.Episodes;
            animeToUpdate.Adaptation = anime.Adaptation;
            animeToUpdate.AiringDay = anime.AiringDay;
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }


        //Delete
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var animeToDelete = dbContext.Animes.FirstOrDefault(c => c.ID == id);
            dbContext.Animes.Remove(animeToDelete);
            dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
