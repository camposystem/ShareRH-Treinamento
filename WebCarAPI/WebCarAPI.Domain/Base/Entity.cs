using System;
using System.Collections.Generic;
using System.Text;
using WebCarAPI.Domain.Interfce;

namespace WebCarAPI.Domain.Base
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public Guid Key { get; set; }

        public Entity()
        {
            Key = Guid.NewGuid();
        }
    }
}
