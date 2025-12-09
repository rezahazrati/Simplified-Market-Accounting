using MarketAccounting.DataLayer;
using MarketAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.Buisinus
{
    public  class CalB
    {
        public  int Cal(int id)
        {
            Product product;
            using(UnitOfWork db = new UnitOfWork())
            {
                product = db.productRepository.GetById(id);
            }
            int bftp = ((product.SoldTillNow) * (product.ProductSellCost)) - ((product.BoughtTillNow) * (product.ProductBuyCost));
            return bftp;
        }
    }
}
