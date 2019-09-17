using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        Japanese,
        American
    }
    public class Restaurant
    {
        [Required, MaxLength(80)]
        [Display (Name ="Restauarant Name")]
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
