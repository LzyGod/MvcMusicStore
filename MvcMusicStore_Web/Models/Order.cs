using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MvcMusicStore_Web.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [ReadOnly(true)]
        public DateTime OrderDate { get; set; }
        [Remote("CheckUserName", "Account")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "姓氏")]
        [StringLength(20, MinimumLength = 3)]
        public string FristName { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorMessages), ErrorMessageResourceName = "LastNameRequired")]
        [Display(Name = "名称")]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9.]+")]
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Email")]
        public string EmailComfirm { get; set; }
        public decimal Total { get; set; }
        [Range(30, 44)]
        public int Age { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}