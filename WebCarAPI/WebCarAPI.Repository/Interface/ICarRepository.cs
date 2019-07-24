using System;
using System.Collections.Generic;
using System.Text;
using WebCarAPI.Domain;

namespace WebCarAPI.Repository.Interface
{
    public interface ICarRepository: IRepository<Car>
    {
        List<Car> GetListForBrand(string brand);
    }
}
