﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        
        [Required]
        public int OrderId { get; set; }

        [ForeignKey(nameof (OrderId))]
        [ValidateNever]
        public OrderHeader OrderHeader { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof (ProductId))]
        [ValidateNever]
        public ProductModel Product { get; set; }

        public int Count { get; set; }
        public double Price { get; set; }
    }
}
