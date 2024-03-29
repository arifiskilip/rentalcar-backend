﻿using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; } = null;
        public bool IsDelivered { get; set; } = false;

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
