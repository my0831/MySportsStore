using MySportsStore.Domain.Abstract;
using MySportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportsStore.Domain.Concrete
{
    public class InMemoryProductRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product>
        {
               new Product {Name="Football", Price=25},
            new Product {Name="Surf Board", Price=179},
            new Product {Name="Running shoes", Price=95},
        };


        public IEnumerable<Product> Products
        {
            get { return Products; }
        }

    }
}
