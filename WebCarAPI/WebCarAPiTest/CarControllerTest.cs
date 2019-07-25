using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using WebCarAPI.Controllers;
using WebCarAPI.Domain;
using WebCarAPI.Service.Interface;
using Xunit;

namespace WebCarAPiTest
{
    public class CarControllerTest
    {
        [Fact]
        public void GetOk()
        {
            var carServiceMock = new Mock<ICarService>();
            var logger = new Mock<ILogger<CarController>>();

            carServiceMock.Setup(
                a => a.Add(It.IsAny<Car>()));

            var carExpectancy = new List<Car>
            {
                new Car(year : "2013" ,brand : "Onix" , model : "Chevrolet"),
                new Car(year : "2014" ,brand : "Prisma" , model : "Chevrolet"),
                new Car(year : "2015" ,brand : "Onix Sedan" , model : "Chevrolet")
            };

            carServiceMock.Setup(a => a.List()).Returns(carExpectancy);

            var controller = new CarController(carServiceMock.Object, logger.Object);

            var retorno = controller.Get();

            var httpObjResult = retorno.Result as OkObjectResult;


            Assert.NotNull(httpObjResult);
            Assert.True(httpObjResult.StatusCode == 200);

            Assert.NotNull(retorno);
            Assert.False(string.IsNullOrWhiteSpace(retorno.ToString()));
       }
        [Fact]
        public void GetInternaServerError()
        {

        }
        [Fact]
        public void PostOk()
        {

        }
        [Fact]
        public void PostBadRequest()
        {

        }
    }
}
