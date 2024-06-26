﻿using Redis.API.Models;

namespace Redis.API.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product); 

    }
}
