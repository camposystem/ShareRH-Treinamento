using AppHotel.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entities

{
    public class Category : Entity
    {   /// <summary>
        ///  Name of Category
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price of Category
        /// </summary>
        public Decimal Price { get; set; }
        /// <summary>
        /// Constructor of Category
        /// </summary>
        public Category()
        {

        }
        public Category(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
