using AnimeProject.Controllers;
using AnimeProject.Interfaces;
using AnimeProject.Models;
using Microsoft.AspNetCore.Mvc;
using MonthsConsole;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class AnimesControllerTest
    {
        private Mock<IRepositoryWrapper> mockRepo;
        private Anime anime;
        private UpdateAnime updateAnime;
        private List<Anime> animes;
        private Mock<IUpdateAnime> updateAnimeMock;
        private Mock<IAnime> animeMock;
        private List<IAnime> animesMock;
        private Mock<IUpdateAnime> updateAnimesMock;
        private Mock<IViewAnime> animeViewModelMock;
        private List<IViewAnime> animesViewModelsMock;


        public AnimesControllerTest()
        {
            //declare what mocks to use 

            //mock setup 

            updateAnimesMock = new Mock<IUpdateAnime>();
            anime = new Anime();
            animes = new List<Anime>();


            //ViewModels Mock setup
            animeViewModelMock = new Mock<IViewAnime>();
            animesViewModelsMock = new List<IViewAnime>();


            //Controller Setup
            //animeControllerMock = new Mock<IAnimeController>();
            var animeMock = new Mock<IAnime>();
            var animeResultsMock = new Mock<IActionResult>();

            mockRepo = new Mock<IRepositoryWrapper>();
            var allAnimes = GetAnimes();
            var animesController = new AnimesController(mockRepo.Object);




        }

        [Fact]
        public void GetAllAnimes_Test()
        {
            //arrange
            mockRepo.Setup(repo => repo.Animes.FindAll()).Returns(GetAnimes);
            

            // ACt (call the controller)

            var controllerActionResult = new AnimesController(mockRepo.Object).Index();
            //assert
            Assert.NotNull(controllerActionResult);


        }
        [Fact]
        public void UpdateAnime_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Animes.FindByCondition(c => c.ID == It.IsAny<int>())).Returns(GetAnimes());
            mockRepo.Setup(repo => repo.Animes.Update(GetAnime()));
            //Act
            var controllerActionResult = new AnimesController(mockRepo.Object).Update(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }

        [Fact]
        public void DeleteAnime_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Animes.FindByCondition(c => c.ID == It.IsAny<int>())).Returns(GetAnimes());
            mockRepo.Setup(repo => repo.Animes.Delete(GetAnime()));
            //Act
            var controllerActionResult = new AnimesController(mockRepo.Object).Delete(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }




        //returns a dummy list 
        private IEnumerable<Anime> GetAnimes()
        {
            var animes = new List<Anime>
            {
              new Anime() { ID = 1, Name = "WEP", Episodes = 5, Adaptation = Adaptation.Yes, AiringDay = AiringDay.Monday},
                new Anime() { ID = 2, Name = "HELLO", Episodes = 10, Adaptation = Adaptation.Yes, AiringDay = AiringDay.Saturday },
            };
            return animes;
        }
         //returns dummmy 1 item
       public Anime GetAnime()
        {
            return GetAnimes().ToList()[0];
        }
        
    }
}


