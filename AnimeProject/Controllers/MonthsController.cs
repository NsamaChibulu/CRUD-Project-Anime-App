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
    public class MonthsController : Controller
    {
        private IRepositoryWrapper repository;
        public MonthsController(IRepositoryWrapper repositoryWrapper)
        {
            repository = repositoryWrapper;
        }


        //private ApplicationDbContext dbContext;
        //public MonthsController(ApplicationDbContext applicationDbContext)
        //{
        //    dbContext = applicationDbContext;
        //}

        //Read
        [Route("")]
        public IActionResult Index()
        {
            var allMonths = repository.Months.FindAll();
            //var allMonths = dbContext.Months.ToList();
            return View(allMonths);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var monthById = repository.Months.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var monthById = dbContext.Months.FirstOrDefault(c => c.ID == id);
            return View(monthById);
        }

        //Create
        [Route("create")]

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddMonthBindingModel bindingModel)
        {
            var monthToCreate = new Month
            {
                Date = bindingModel.Date,
                Year = bindingModel.Year,

            };
            repository.Months.Create(monthToCreate);
            repository.Save();
            //dbContext.Months.Add(monthToCreate);
            //dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        //Anime section
        //Create 
        //Create
        [Route("addanime/{monthID:int}")]

        public IActionResult CreateAnime(int monthID)
        {
            var month = repository.Months.FindByCondition(c => c.ID == monthID);
            //var month = dbContext.Months.FirstOrDefault(c => c.ID == monthID);
            ViewBag.MonthDate = month.ToList()[0].Date;
            ViewBag.MonthID = month.ToList()[0].ID;
            return View();
        }
        [HttpPost]
        [Route("addanime/{monthID:int}")]
        public IActionResult CreateAnime(AddAnimeBindingModel bindingModel, int monthID)
        {
            var animeToCreate = new Anime
            {
                Name = bindingModel.Name,
                Episodes = bindingModel.Episodes,
                Adaptation = bindingModel.Adaptation,
                MonthID = monthID,
                //Month = dbContext.Months.FirstOrDefault(c => c.ID == bindingModel.MonthID),
                AiringDay = bindingModel.AiringDay,
                PictureURL = "https://i.pinimg.com/474x/84/aa/0d/84aa0dadd6cbd869bf40397a1a59e4cb.jpg"

            };
            repository.Animes.Create(animeToCreate);
            repository.Save();
            //dbContext.Animes.Add(animeToCreate);
            //dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        [Route("{id:int}/animes")]
        public IActionResult ViewAnimes(int id)
        {
            var month = repository.Months.FindByCondition(c => c.ID == id).FirstOrDefault();
            var animes = repository.Animes.FindByCondition(c => c.MonthID == id);
            //var month = dbContext.Months.FirstOrDefault(c => c.ID == id);
            //var animes = dbContext.Animes.Where(c => c.Month.ID == id).ToList();
            ViewBag.MonthDate = month.Date;
            return View(animes);
        }



        //Update 
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var monthById = repository.Months.FindByCondition(c => c.ID == id).FirstOrDefault();
            //var monthById = dbContext.Months.FirstOrDefault(c => c.ID == id);
            return View(monthById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Month month, int id)
        {
            repository.Months.Update(month);
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");

        }


        //Delete
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var monthToDelete = repository.Months.FindByCondition(c => c.ID == id).FirstOrDefault();
            repository.Months.Delete(monthToDelete);
           repository.Save();
            //var monthToDelete = dbContext.Months.FirstOrDefault(c => c.ID == id);
            //dbContext.Months.Remove(monthToDelete);
            //dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

    }

}


