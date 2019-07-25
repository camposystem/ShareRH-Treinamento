using System;
using System.Collections.Generic;
using WebCarAPI.Business.Interface;
using WebCarAPI.Domain;
using WebCarAPI.Service.Interface;

namespace WebCarAPI.Service
{
    public class CarService : ICarService
    {

        private readonly ICarBusiness _carBusiness;

        public CarService(ICarBusiness carBusiness)
        {
            _carBusiness = carBusiness;
        }

        public void Add(Car car)
        {
            _carBusiness.Add(car);
        }

        public Car Get(Guid key)
        {
          return  _carBusiness.Get(key);
        }

        public List<Car> List()
        {
           return _carBusiness.List();
        }

        public List<Car> ListForBrand(string brand)
        {
           return _carBusiness.ListForBrand(brand);
        }


        public List<Car> ListAll()
        {
            return _carBusiness.ListAll();
        }

    }
}
