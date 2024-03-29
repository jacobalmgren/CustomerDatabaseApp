﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerDatabaseApp.Entities
{
    public class OrderEntity
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        public CustomerEntity Customer { get; set; }

        public decimal? TotalAmount { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        [MaxLength(200)]
        public string? ShippingAddress { get; set; }

        public List<OrderItemEntity> OrderItems { get; set; }
    }
}
