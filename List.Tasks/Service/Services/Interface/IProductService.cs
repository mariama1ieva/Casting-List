using List.Tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Tasks.Services.Interface
{
    internal interface IProductService
    {
        public List<Product> GetAll();

    }
}
