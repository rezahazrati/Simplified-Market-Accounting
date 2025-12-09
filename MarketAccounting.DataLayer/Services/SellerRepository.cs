using System;
using System.Collections.Generic;
using MarketAccounting.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketAccounting.DataLayer.Repository;

namespace MarketAccounting.DataLayer.Services
{
    public class SellerRepository : ISellerRepository
    {
        private MarketAccounting_DBEntities db;

        public SellerRepository(MarketAccounting_DBEntities context)
        {
            db = context;
        }

        public List<ListSellerViewModel> GetSellerName(string filter = "")
        {
            if (filter == "")
            {
                return db.PWYBF.Select(s => new ListSellerViewModel() { SellerId = s.PWYBFId, SellerName = s.Name }).ToList();
            }
            return db.PWYBF.Where(s=> s.Name.Contains(filter)).Select(s => new ListSellerViewModel() { SellerId = s.PWYBFId, SellerName = s.Name }).ToList();
        }
    }
}
