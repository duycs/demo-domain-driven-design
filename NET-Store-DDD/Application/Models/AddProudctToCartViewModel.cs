﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StoreDDD.ApplicationLayer.Models
{
    /// <summary>
    /// Class AddProudctToCartViewModel.
    /// </summary>
    public class AddProudctToCartViewModel
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        [Required(ErrorMessage = "The customer id is required")]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        [Required(ErrorMessage = "The product id is required")]
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [Required(ErrorMessage = "quantity is required")]
        public int Quantity { get; set; }
    }
}
