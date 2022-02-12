using InvApiServices.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Repository.Interfaces
{
    public interface IPurchaseOrderRepo
    {

        
        Task<IEnumerable<PurchaseOrder>> GetAllPOByClient(string clientAcct);

        Task<IEnumerable<PurchaseOrder>> GetPOBySupplier(int Id);

        Task<IEnumerable<PurchaseOrder>> GetPOByStatus(string status, string clientAcct);

        Task<IEnumerable<PurchaseOrder>> GetPOByDateRange( DateTime dateFrom, DateTime dateTo, string clientAcct);

        Task<PurchaseOrder> GetPOByOrderId(string OrderId);
        Task<IEnumerable<OrderItem>> GetOrderItemByOrderId(string OrderId);

        Task<OrderItem> GetOrderItemByOrderItemId(int id);

        Task<bool> Save(PurchaseOrder order);
        Task<bool> Update(PurchaseOrder order);
        Task<bool> Delete(PurchaseOrder order);

        Task<bool> SaveItem(OrderItem orderItem);
        Task<bool> UpdateItem(OrderItem orderItem);
        Task<bool> DeleteItem(OrderItem orderItem);

    }
}
