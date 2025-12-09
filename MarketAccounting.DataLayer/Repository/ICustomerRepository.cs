using System;
using MarketAccounting.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {
        List<ListCustomerViewModel> GetCustomerName(string filter = "");
    }
}
