using System;
using System.Collections.Generic;

namespace ShoppingApp.WebAPI.Entities.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public CategoryResource Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public ICollection<ColorResource> Colors { get; set; }
        public ICollection<ModelResource> Models { get; set; }

        public ProductResource()
        {
            Colors = new HashSet<ColorResource>();
            Models = new HashSet<ModelResource>();
        }
    }
}