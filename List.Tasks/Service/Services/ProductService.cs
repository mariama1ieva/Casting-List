using List.Tasks.Models;
using List.Tasks.Services.Data;
using List.Tasks.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Tasks.Services
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }
    }
}
