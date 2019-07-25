
using System.Collections.Generic;
using System.Linq;
using WebCarAPI.Domain;
using WebCarAPI.Domain.Interfce;
using WebCarAPI.Repository.Base;
using WebCarAPI.Repository.Interface;

namespace WebCarAPI.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public List<Car> GetListForBrand(string brand)
        {
            return Get().Where(b => b.Brand == brand).ToList();
        }

        public List<Car> ListAllCars()
        {
            var query = "Select * from TB_Car";

            return this.Query(query).ToList();

        }
    }

}
