using InvApiServices.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Services.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task<IEnumerable<POViewModel>> GetAllPOByClient(string clientAcct);
        Task<IEnumerable<POViewModel>> GetPOBySupplier(int Id);

        Task<IEnumerable<POViewModel>> GetPOByStatus(string status, string clientAcct);
       
        Task<IEnumerable<POViewModel>> GetPOByDateRange(DateTime dateFrom, DateTime dateTo, string clientAcct);
        Task<POViewModel> GetPOByOrderId(string orderId);

        Task<OrderItemViewModel> GetOrderItemByOrderItemId(int id);

        Task<bool> Save(POViewModel order);
        Task<bool> Update(POViewModel order);
        Task<bool> Delete(string orderId);

        string GenerateOrderId(string ClientAccount);
    }
}
