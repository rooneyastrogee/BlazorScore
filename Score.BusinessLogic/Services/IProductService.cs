using Microsoft.EntityFrameworkCore;
using Scores.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score.BusinessLogic.Services
{
    public interface IProductService
    {
       
        List<Product> getProducts();

       
         
    }

}
