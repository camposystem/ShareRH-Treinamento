using System;
using System.Collections.Generic;
using WebCarAPI.Domain;

namespace WebCarAPI.Business.Interface
{
    public interface ICarBusiness
    {
        void Add(Car car);
        List<Car> List();
        List<Car> ListForBrand(string brand);
        Car Get(Guid key);

    }
}
