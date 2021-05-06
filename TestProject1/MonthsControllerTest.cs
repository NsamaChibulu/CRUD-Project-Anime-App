using AnimeProject.Controllers;
using AnimeProject.Interfaces;
using AnimeProject.Models;
using AnimeProject.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using MonthsConsole;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestProject1
{
    public class MonthsControllerTest
    {
        private Mock<IRepositoryWrapper> mockRepo;
        private Month month;
        private AddMonth _addMonth;
        private UpdateMonth updateMonth;
        private List<Month> months;
        private Mock<IUpdateMonth> updateMonthMock;
        private Mock<IMonth> monthMock;
        private List<IMonth> monthsMock;
        private Mock<IAddMonth> addMonthsMock;
        private Mock<IUpdateMonth> updateMonthsMock;
        private Mock<IViewMonth> monthViewModelMock;
        private List<IViewMonth> monthsViewModelsMock;

        public MonthsControllerTest() {
            //declare what mocks to use 

            //mock setup 
            monthMock = new Mock<IMonth>();
            monthsMock = new List<IMonth> { monthMock.Object };
            addMonthsMock = new Mock<IAddMonth>();
            updateMonthsMock = new Mock<IUpdateMonth>();
            month = new Month();
            months = new List<Month>();


            //ViewModels Mock setup
            monthViewModelMock = new Mock<IViewMonth>();
            monthsViewModelsMock = new List<IViewMonth>();


            //Controller Setup
            //monthControllerMock = new Mock<IMonthController>();

            var animeMock = new Mock<IAnime>();
            var monthResultsMock = new Mock<IActionResult>();

            mockRepo = new Mock<IRepositoryWrapper>();
            var allMonths = GetMonths();
            var monthsController = new MonthsController(mockRepo.Object);


        }





        [Fact]
        public void GetAllMonths_Test()
        {
            //arrange
          mockRepo.Setup(repo=> repo.Months.FindAll()).Returns(GetMonths);
            mockRepo.Setup(repo => repo.Animes.FindByCondition(c => c.MonthID == It.IsAny<int>())).Returns(GetAnimes());

            // ACt (call the controller)

            var controllerActionResult = new MonthsController(mockRepo.Object).Index();
            //assert
            Assert.NotNull(controllerActionResult);


        }

     
        private IEnumerable<Anime> GetAnimes()
        {
            return new List<Anime>()
            {
                new Anime { ID = 1, Month = GetMonths().ToList()[0] },
                 new Anime { ID = 1, Month = GetMonths().ToList()[1] },
             };
        }

        //returns a dummy list 
        private IEnumerable<Month> GetMonths()
        {
            var months = new List<Month>
            {
                new Month(){ID=1,Date = Date.July, Year = 2021 },
                new Month(){ID=2,Date = Date.June, Year = 2021 },
                new Month(){ID=3,Date = Date.May, Year = 2021 },
                new Month(){ID=4,Date = Date.November, Year = 2021 },
            };
            return months;
        }
        // returns dummmy 1 item
         public Month GetMonth()
        {
            return GetMonths().ToList()[0];
        }

    }
}
