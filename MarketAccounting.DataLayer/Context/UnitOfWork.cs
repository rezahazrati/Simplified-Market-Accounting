using MarketAccounting.DataLayer.Services;
using System;
using MarketAccounting.DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAccounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        MarketAccounting_DBEntities db = new MarketAccounting_DBEntities();
        private GenericRepository<Product> _productRepository;
        private GenericRepository<SlAndBu> _bsRepository;
        private GenericRepository<Customers> _customerRepository;
        private GenericRepository<PWYBF> _sellerRepository;
        
        private CustomerRepository _CustomerRepository;
        private SellerRepository _SellerRepository;
        private ProductRepository _ProductRepository;

        public GenericRepository<Customers> customerRepository
        {
            get
            {
                if(_customerRepository==null)
                {
                    _customerRepository = new GenericRepository<Customers>(db);
                }
                return _customerRepository;
            }
        }

        public GenericRepository<PWYBF> sellerRepository
        {
            get
            {
                if(_sellerRepository==null)
                {
                    _sellerRepository = new GenericRepository<PWYBF>(db);
                }
                return _sellerRepository;
            }
        }
        public GenericRepository<Product> productRepository
        {
            get
            {
                if(_productRepository==null)
                {
                    _productRepository = new GenericRepository<Product>(db);
                }
                return _productRepository;
            }
        }

        public ProductRepository ProductRepository
        {
            get
            {
                if(_ProductRepository==null)
                {
                    _ProductRepository = new ProductRepository(db);
                }
                return _ProductRepository;
            }
        }

        public CustomerRepository CustomerRepository
        {
            get
            {
                if(_CustomerRepository==null)
                {
                    _CustomerRepository = new CustomerRepository(db);
                }
                return _CustomerRepository;
            }
        }

        public SellerRepository SellerRepository
        {
            get
            {
                if(_SellerRepository==null)
                {
                    _SellerRepository = new SellerRepository(db);
                }
                return _SellerRepository;
            }
        }
        public GenericRepository<SlAndBu> bsRepository
        {
            get
            {
                if(_bsRepository==null)
                {
                    _bsRepository = new GenericRepository<SlAndBu>(db);
                }
                return _bsRepository;
            }
        }

        
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
