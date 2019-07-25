using WebCarAPI.Domain.Base;

namespace WebCarAPI.Domain
{
    public class Car: Entity
    {
        public Car(string year, string brand, string model)
        {
            Year = year;
            Brand = brand;
            Model = model;
        }

        public Car(int id, string year, string brand, string model)
        {
            Id = id;
            Year = year;
            Brand = brand;
            Model = model;
        }


        public string Year{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

    }
}
