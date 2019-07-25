using System;
using System.Collections.Generic;
using WebCarAPI.Business.Interface;
using WebCarAPI.Domain;
using WebCarAPI.Repository.Interface;

namespace WebCarAPI.Business
{


    public class CarBusiness: ICarBusiness
    {

        private readonly ICarRepository _carRepository;

        public CarBusiness(ICarRepository carRepository)
        {
            _carRepository = carRepository;

        }

        public void Add(Car car)
        {
            _carRepository.Create(car);
        }

        public Car Get(Guid key)
        {
            return _carRepository.Get(key);
        }

        public List<Car> List()
        {
            return _carRepository.Get();
        }


        public List<Car> ListAll()
        {
            return _carRepository.ListAllCars();
        }


        public List<Car> ListForBrand(string brand)
        {
            return _carRepository.GetListForBrand(brand);
        }
    }
}
