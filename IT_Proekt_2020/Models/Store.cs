using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Proekt_2020.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Име")]
        public string Name { get; set; }
        [Display(Name="Локација")]
        public string Address { get; set; }
        
        public virtual List<Product> products { get; set; }
        public Store()
        {
            products = new List<Product>();
        }
    }
}