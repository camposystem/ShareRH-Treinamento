using AppHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppHotel.Repository
{
    public class RoomRepository : Repository<Room>
    {


        public List<Room> GetValue(string value)
        {
            var amount = int.Parse(value);
            return Get().FindAll(x => x.amountRoom == amount);
        }

    }
}
