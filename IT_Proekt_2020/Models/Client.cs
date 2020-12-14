using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Proekt_2020.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public int Naracki { get; set; }
        public int Poeni { get; set; }
        public int broj { get; set; }
        public int vozrast { get; set; }
        public int asd { get; set; }

    }
}