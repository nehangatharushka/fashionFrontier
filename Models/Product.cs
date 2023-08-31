using System;
using System.Collections.Generic;

#nullable disable

namespace fashionFrontier.Models
{
    public partial class Product
    {
        public int Prodid { get; set; }
        public string Category { get; set; }
        public string Branding { get; set; }
        public string WearType { get; set; }
        public string Tags { get; set; }
        public string ProdName { get; set; }
        public string ImgUrl { get; set; }
        public bool? Predition { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
