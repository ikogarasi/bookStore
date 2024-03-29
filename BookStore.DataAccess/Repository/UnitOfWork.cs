﻿using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Categories = new CategoryRepository(_db);
            CoverTypes = new CoverTypeRepository(_db);
            Products = new ProductRepository(_db);
            Companies = new CompanyRepository(_db);
            UsersData = new UserDataRepository(_db);
            ShoppingCarts = new ShoppingCartRepository(_db);
        }

        public ICategoryRepository Categories { get; private set; }
        public ICoverTypeRepository CoverTypes { get; private set; }
        public IProductRepository Products { get; private set; }
        public ICompanyRepository Companies { get; private set; }
        public IUserDataRepository UsersData { get; private set; }
        public IShoppingCartRepository ShoppingCarts { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
