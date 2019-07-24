using System;
using System.Collections.Generic;
using WebCarAPI.Domain;

namespace WebCarAPI.Service.Interface
{
    public interface ICarService
    {
        void Add(Car car);
        List<Car> List();
        List<Car> ListForBrand(string brand);
        Car Get(Guid key);
    }
}
