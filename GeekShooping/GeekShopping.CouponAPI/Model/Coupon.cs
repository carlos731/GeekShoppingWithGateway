﻿using GeekShopping.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CouponAPI.Model
{
    [Table("coupon")]
    public class Coupon : BaseEntity
    { 
        [Column("coupon_code")]
        [Required]
        [StringLength(30)]
        public string CouponCode { get; set; }
        
        [Column("discount_amount")]
        [Required]
        [Range(1, 10000)]
        public decimal DiscountAmount { get; set; }
        
    }
}
