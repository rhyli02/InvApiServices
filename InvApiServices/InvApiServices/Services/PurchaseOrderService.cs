using InvApiServices.Models.Context;
using InvApiServices.Models.ViewModel;
using InvApiServices.Repository.Interfaces;
using InvApiServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepo _repo;

        public PurchaseOrderService(IPurchaseOrderRepo repo)
        {
            _repo = repo;
        }

       

        public async Task<IEnumerable<POViewModel>> GetAllPO()
        {
            try
            {
                List<POViewModel> res = new List<POViewModel>();
                var allPO =await _repo.GetAllPO();
                foreach (var item in allPO)
                {
                    var orderitems = await _repo.GetOrderItemByOrderId(item.OrderId);

                    res.Add(MapPOtoVM(item, orderitems.ToList()));
                }

                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OrderItemViewModel> GetOrderItemByOrderItemId(int id)
        {
            try
            {
                var order = await _repo.GetOrderItemByOrderItemId(id);
                return MapOrderItemtoVM(order);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        public async Task<IEnumerable<POViewModel>> GetPOByDateRange(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var ordersVM = new List<POViewModel>();
                var orders =await _repo.GetPOByDateRange(dateFrom, dateTo);

                foreach (var item in orders)
                {
                    var orderitems = await _repo.GetOrderItemByOrderId(item.OrderId);
                    ordersVM.Add(MapPOtoVM(item, orderitems.ToList()));
                }

                return ordersVM;

            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public async Task<POViewModel> GetPOByOrderId(string orderId)
        {
            try
            {
                var order = await _repo.GetPOByOrderId(orderId);
                var orderItem = await _repo.GetOrderItemByOrderId(orderId);

                return MapPOtoVM(order, orderItem.ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<POViewModel>> GetPOByStatus(string status)
        {
            try
            {
                var ordersVM = new List<POViewModel>();
                var orders = await _repo.GetPOByStatus(status);

                foreach (var item in orders)
                {
                    var orderitems = await _repo.GetOrderItemByOrderId(item.OrderId);
                    ordersVM.Add(MapPOtoVM(item, orderitems.ToList()));
                }

                return ordersVM;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<POViewModel>> GetPOBySupplier(int Id)
        {
            try
            {
                var ordersVM = new List<POViewModel>();
                var orders = await _repo.GetPOBySupplier(Id);

                foreach (var item in orders)
                {
                    var orderitems = await _repo.GetOrderItemByOrderId(item.OrderId);
                    ordersVM.Add(MapPOtoVM(item, orderitems.ToList()));
                }

                return ordersVM;
                -
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> Save(POViewModel order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(POViewModel order)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(POViewModel order)
        {
            throw new NotImplementedException();
        }

        private OrderItemViewModel MapOrderItemtoVM(OrderItem orderItem)
        {
            OrderItemViewModel orderItemView = new OrderItemViewModel
            {
                Id = orderItem.Id,
                OrderId = orderItem.OrderId,
                ProductId = orderItem.ProductId,
                Qty = orderItem.Qty,
                OrderUnit = orderItem.OrderUnit,
                Discount = orderItem.Discount,
                Amount = orderItem.Amount,
                Date = orderItem.Date,
                CreatedBy = orderItem.CreatedBy
            };

            return orderItemView;
        }

        private POViewModel MapPOtoVM(PurchaseOrder order, List<OrderItem> orderItems)
        {
            try
            {
                var orderItemsVM = (from item in orderItems
                                    select MapOrderItemtoVM(item)).ToList();
                var pOView = new POViewModel
                {
                    Id = order.Id,
                    OrderId = order.OrderId,
                    CategoryId = order.CategoryId,
                    SupplierId = order.SupplierId,
                    Date = order.Date,
                    Terms = order.Terms,
                    Shipment = order.Shipment,
                    Currency = order.Currency,
                    SubTotal = order.SubTotal,
                    Vat = order.Vat,
                    GrandTotal = order.GrandTotal,
                    Status = order.Status,
                    Notes = order.Notes,
                    OrderItems = orderItemsVM
                };




                return pOView;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
