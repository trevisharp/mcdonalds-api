using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace McDonaldsAPI.Services;

using Model;

public class FakeOrderRepository : IOrderRepository
{
    int orderId = 42;

    public async Task<int> CreateOrder(int storeId)
    {
        return orderId;
    }

    public async Task CancelOrder(int orderId)
    {
        orderId = Random.Shared.Next();
    }

    public Task<List<Product>> GetMenu(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetOrderItems(int orderId)
    {
        throw new NotImplementedException();
    }

    public async Task AddItem(int orderId, int productId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveItem(int orderId, int productId)
    {
        throw new NotImplementedException();
    }

    public Task FinishOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task DeliveryOrder(int orderId)
    {
        throw new NotImplementedException();
    }
}