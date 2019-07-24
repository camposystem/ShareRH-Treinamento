using System;
using System.Collections.Generic;
using System.Text;

namespace WebCarAPI.Domain.Interfce
{
    public interface IEntity
    {

        int Id { get; set; }
        Guid Key { get; set; }
    }
}
