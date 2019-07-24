using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Interface
{
    public interface IEntity
    {

        int Id { get; set; }
        Guid Key { get; set; }


    }
}
