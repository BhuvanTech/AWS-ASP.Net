using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLambda.Models
{
    public class CreateProductRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class CreateProductResponse
    {
        public string? ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
