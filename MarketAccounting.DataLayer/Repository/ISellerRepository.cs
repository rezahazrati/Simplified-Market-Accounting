using System;
using System.Collections.Generic;
using MarketAccounting.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.DataLayer.Repository
{
    public interface ISellerRepository
    {
        List<ListSellerViewModel> GetSellerName(string filter = "");
    }
}
