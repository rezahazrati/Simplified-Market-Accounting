using System;
using System.Collections.Generic;
using System.Linq;
using MarketAccounting.DataLayer.Repository;
using System.Text;
using System.Threading.Tasks;
using MarketAccounting.ViewModels;

namespace MarketAccounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private MarketAccounting_DBEntities db;

        public CustomerRepository(MarketAccounting_DBEntities context)
        {
            db = context;
        }

        public List<ListCustomerViewModel> GetCustomerName(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel() { CustomerId = c.CustomerId, CustomerName = c.CustomerName }).ToList();
            }
            return db.Customers.Where(c=> c.CustomerName.Contains(filter)).Select(c=> new ListCustomerViewModel() { CustomerId = c.CustomerId, CustomerName = c.CustomerName }).ToList();
        }
    }
}
