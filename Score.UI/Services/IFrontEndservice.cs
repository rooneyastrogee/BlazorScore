using Microsoft.EntityFrameworkCore;
using Scores.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score.UI.Service
{
    public interface IFrontEndservice
    {

        Task<List<Product>>getProducts();  
         
    }

}
