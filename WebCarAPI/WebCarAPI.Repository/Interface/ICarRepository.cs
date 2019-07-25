using WebCarAPI.Domain.Interfce;
using System.Collections.Generic;
using WebCarAPI.Domain;

namespace WebCarAPI.Repository.Interface
{
    public interface ICarRepository: IRepository<Car>
    {
        List<Car> GetListForBrand(string brand);
        List<Car> ListAllCars();
    }
}
