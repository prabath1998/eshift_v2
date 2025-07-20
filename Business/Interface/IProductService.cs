﻿using eShift_Logistics_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShift_Logistics_System.Business.Interface
{
   public interface IProductService
    {
        
        void AddProduct(Product product);

        void UpdateProduct(Product product);
       
        bool DeleteProduct(int id);
       
        List<Product> GetAllProducts();
       
        Product GetProductById(int id);

    }
}
