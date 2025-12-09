using MarketAccounting.DataLayer.Repository;
using MarketAccounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.DataLayer.Services
{
    public class ProductRepository : IProductRepository
    {

        private MarketAccounting_DBEntities db;
        
        public ProductRepository(MarketAccounting_DBEntities context)
        {
            db = context;
        }
        public List<ListProductViewModels> GetProductName(string filter = "")
        {
            if (filter == "")
            {
                return db.Products.Select(p => new ListProductViewModels() { ProductId = p.ProductId, ProductName = p.ProductName }).ToList();
            }
            return db.Products.Where(p => p.ProductName.Contains(filter)).Select(p => new ListProductViewModels() { ProductId = p.ProductId, ProductName = p.ProductName }).ToList();
        }
    }
}
