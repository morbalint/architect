﻿using System;

namespace Architect.Database.Infrastructure
{
    public abstract class AggregateEntityBase
    {
        public AggregateEntityBase()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public int AggregateRootId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
