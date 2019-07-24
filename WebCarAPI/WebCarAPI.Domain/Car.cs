using System;
using System.Collections.Generic;
using System.Text;
using WebCarAPI.Domain.Base;
using WebCarAPI.Domain.Interfce;

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

        public string Year{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

    }
}
