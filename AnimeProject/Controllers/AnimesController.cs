using AnimeProject.Data;
using AnimeProject.Interfaces;
using AnimeProject.Models;
using AnimeProject.Models.Binding;
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
        private IRepositoryWrapper repository;
        public AnimesController(IRepositoryWrapper repositoryWrapper)
        {
            repository = repositoryWrapper;
        }

        //private ApplicationDbContext dbContext;
        //public AnimesController(ApplicationDbContext applicationDbContext)
        //{
        //    dbContext = applicationDbContext;
        //}

        //Read
        public IActionResult Index()
        {
            var allanimes = repository.Animes.FindAll();
            return View(allanimes);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var animeById = repository.Animes.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(animeById);
        }

        //public IActionResult Index()
        //{
        //    var allanimes = dbContext.Animes.ToList();
        //    return View(allanimes);
        //}
        //[Route("details/{id:int}")]
        //public IActionResult Details(int id)
        //{
        //    var animeById = dbContext.Animes.FirstOrDefault(c => c.ID == id);
        //    return View(animeById);
        //}




        //Update 
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var animeById = repository.Animes.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(animeById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Anime anime, int id)
        {
            var animeToUpdate = repository.Animes.FindByCondition(c => c.ID == id).FirstOrDefault();
            {
               
                animeToUpdate.Name = anime.Name;
                animeToUpdate.Episodes = anime.Episodes;
                animeToUpdate.Adaptation = anime.Adaptation;
                animeToUpdate.AiringDay = anime.AiringDay;
                animeToUpdate.PictureURL = anime.PictureURL;
               
            };
            repository.Animes.Update(animeToUpdate);
            repository.Save();
            return RedirectToAction("Index");

        }
        //public IActionResult Update(int id)
        //{
        //    var animeById = dbContext.Animes.FirstOrDefault(c => c.ID == id);
        //    return View(animeById);
        //}
        //[HttpPost]
        //[Route("update/{id:int}")]
        //public IActionResult Update(Anime anime, int id)
        //{
        //    var animeToUpdate = dbContext.Animes.FirstOrDefault(c => c.ID == id);
        //    animeToUpdate.Name = anime.Name;
        //    animeToUpdate.Episodes = anime.Episodes;
        //    animeToUpdate.Adaptation = anime.Adaptation;
        //    animeToUpdate.AiringDay = anime.AiringDay;
        //    animeToUpdate.PictureURL = anime.PictureURL;
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");

        //}

        //Delete
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var animeToDelete = repository.Animes.FindByCondition(c => c.ID == id).FirstOrDefault();
           repository.Animes.Delete(animeToDelete);
            repository.Save();

            return RedirectToAction("Index");

        }

        //[Route("delete/{id:int}")]
        //public IActionResult Delete(int id)
        //{
        //    var animeToDelete = dbContext.Animes.FirstOrDefault(c => c.ID == id);
        //    dbContext.Animes.Remove(animeToDelete);
        //    dbContext.SaveChanges();

        //    return RedirectToAction("Index");
        }
    }

