using Scores.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score.BusinessLogic.Services
{

    public class ProductService : IProductService
    {
        private readonly PeopleDBContext _dbContext = null;

        public ProductService(PeopleDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Product> getProducts()
        {
            

                return _dbContext.Products.ToList();
           
        }
    }
}
