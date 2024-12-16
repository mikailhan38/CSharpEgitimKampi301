using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                    .Select(p => new
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        ProductStock = p.ProductStock,
                        ProductPrice = p.ProductPrice,
                        ProductDescription = p.ProductDescription,
                        CategoryId = p.CategoryId,
                        CategoryName = p.Category.CategoryName
                    }).ToList();
                return values.Cast<object>().ToList();
            
        }
    }
}
