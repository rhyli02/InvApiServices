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

        public async Task<IEnumerable<POViewModel>> GetAllPOByClient(string clientAcct)
        {
            try
            {
                List<POViewModel> res = new List<POViewModel>();
                var allPO =await _repo.GetAllPOByClient(clientAcct);
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

        public async Task<IEnumerable<POViewModel>> GetPOByDateRange(DateTime dateFrom, DateTime dateTo, string clientAcct)
        {
            try
            {
                var ordersVM = new List<POViewModel>();
                var orders =await _repo.GetPOByDateRange(dateFrom, dateTo,clientAcct);

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

        public async Task<IEnumerable<POViewModel>> GetPOByStatus(string status, string clientAcct)
        {
            try
            {
                var ordersVM = new List<POViewModel>();
                var orders = await _repo.GetPOByStatus(status,clientAcct);

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
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> Save(POViewModel order)
        {
            try
            {
                bool response = false;
                var res = MapVMtoPO(order);
                response = await _repo.Save(res);
                if (response)
                {
                    foreach (var item in order.OrderItems)
                    {
                        item.OrderId = order.OrderId;
                        var orderitem = MapVmToOrderItem(item);
                        response = await _repo.SaveItem(orderitem);
                        if (!response) return response;
                    }
                }

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Update(POViewModel order)
        {
            try
            {
                bool response = false;
                var po = await _repo.GetPOByOrderId(order.OrderId);
                
                po.CategoryId = order.CategoryId;
                po.SupplierId = order.SupplierId;
                po.Date = order.Date;
                po.Terms = order.Terms;
                po.Shipment = order.Shipment;
                po.Currency = order.Currency;
                po.SubTotal = order.SubTotal;
                po.Vat = order.Vat;
                po.GrandTotal = order.GrandTotal;
                po.Status = order.Status;
                po.Notes = order.Notes;

                response = await _repo.Update(po);

                var orderItemList = await _repo.GetOrderItemByOrderId(order.OrderId);
                foreach (var item in order.OrderItems)
                {
                    if (item.Id >= 1)
                    {
                        var oi = await _repo.GetOrderItemByOrderItemId(item.Id);
                        oi.OrderId = item.OrderId;
                        oi.ProductId = item.ProductId;
                        oi.Qty = item.Qty;
                        oi.OrderUnit = item.OrderUnit;
                        oi.Discount = item.Discount;
                        oi.Amount = item.Amount;
                        oi.Date = item.Date;
                        oi.CreatedBy = item.CreatedBy;

                        response = await _repo.UpdateItem(oi);
                    }
                    else
                    {
                        var newoi = MapVmToOrderItem(item);
                        response = await _repo.SaveItem(newoi);
                    }
                    if (!response) return response;

                }

                return response;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Delete(string orderId)
        {
            try
            {
                bool response = false;
                var OrderItems = await _repo.GetOrderItemByOrderId(orderId);
                foreach (var item in OrderItems)
                {                  
                    response = await _repo.DeleteItem(item);
                    if (!response) return response;
                }
                var po = await _repo.GetPOByOrderId(orderId);
                response = await _repo.Delete(po);

                return response;

            }
            catch (Exception)
            {
                throw;
            }
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
                    OrderItems = orderItemsVM,
                    ClientAccount = order.ClientAccount
                };




                return pOView;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private PurchaseOrder MapVMtoPO(POViewModel collect)
        {
            var model = new PurchaseOrder
            {
                OrderId = collect.OrderId,
                CategoryId = collect.CategoryId,
                SupplierId = collect.SupplierId,
                Date = collect.Date,
                Terms = collect.Terms,
                Shipment = collect.Shipment,
                Currency = collect.Currency,
                SubTotal = collect.SubTotal,
                Vat = collect.Vat,
                GrandTotal = collect.GrandTotal,
                Status = collect.Status,
                Notes = collect.Notes,
                ClientAccount =collect.ClientAccount
               
            };

            return model;

        }
        private OrderItem MapVmToOrderItem(OrderItemViewModel order)
        {

            OrderItem orderItem = new OrderItem
            {
                OrderId = order.OrderId,
                ProductId = order.ProductId,
                Qty = order.Qty,
                OrderUnit = order.OrderUnit,
                Discount = order.Discount,
                Amount = order.Amount,
                Date = order.Date,
                CreatedBy = order.CreatedBy
            };

            return orderItem;
        }

        public string GenerateOrderId(string ClientAccount)
        {
            string orderId= ClientAccount + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 3);
            return orderId;
        }
    }
}
