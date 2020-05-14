using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProducto.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "productid")]
        public int ProductId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }
    }
}
