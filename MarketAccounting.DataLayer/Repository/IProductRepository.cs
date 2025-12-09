using System;
using System.Collections.Generic;
using System.Linq;
using MarketAccounting.ViewModels;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.DataLayer.Repository
{
    public interface IProductRepository
    {
        List<ListProductViewModels> GetProductName(string filter="");
    }
}
