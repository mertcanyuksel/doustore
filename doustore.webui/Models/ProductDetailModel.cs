using System.Collections.Generic;
using doustore.entity;

namespace doustore.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}