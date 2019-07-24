using AppHotel.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entities
{
    public class Room: Entity
    {

        public Room(Category categories, int amountRoom, byte isActive)
        {
            this.categories = categories;
            this.amountRoom = amountRoom;
            this.isActive = isActive;
        
        }


 
        /// <summary>
        ///  Category of Room
        /// </summary>
        public Category categories { get; set; }
        /// <summary>
        /// amount of Room
        /// </summary>
        public int amountRoom { get; set; }
        /// <summary>
        /// Room Active
        /// </summary>
        public byte isActive{ get; set; }
  




    }
}
