using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Proekt_2020.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Име")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [StringLength(5, MinimumLength = 5)]
        [Display(Name="Код")]
        public string ProductCode { get; set; }
        [Display(Name="Цена")]
        public float Price { get; set; }
        [Display(Name="Слика")]
        public string Image { get; set; }
        [Display(Name="Преостаната количина")]
        public int AvailableQuantity { get; set; }
    }
}