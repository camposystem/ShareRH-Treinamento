using System;
using System.Collections.Generic;
using System.Text;

namespace WebCarAPI.Domain.Base
{
    public class Entity : Interfce.IEntity
    {
        public int Id { get; set; }
        public Guid Key { get; set; }

        public Entity()
        {
            Key = Guid.NewGuid();
        }
    }
}
