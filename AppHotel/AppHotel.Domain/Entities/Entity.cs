using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Interface
{
    public abstract class Entity : IEntity
    {   /// <summary>
    /// identity of Entity
    /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Guid of Entity
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// Constructor of Entity
        /// </summary>
        public Entity()
        {
            Key =  Guid.NewGuid();
        }
    }
}
