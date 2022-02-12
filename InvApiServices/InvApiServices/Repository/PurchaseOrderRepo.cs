using InvApiServices.Models.Context;
using InvApiServices.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Repository
{
    public class PurchaseOrderRepo: IPurchaseOrderRepo
    {
        private readonly InvDBContext _context;

        public PurchaseOrderRepo(InvDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PurchaseOrder>> GetAllPOByClient(string clientAcct)
        {
            try
            {
                return await (from item in _context.PurchaseOrders
                              where item.ClientAccount.Equals(clientAcct)
                              select item).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<IEnumerable<PurchaseOrder>> GetPOByDateRange(DateTime dateFrom, DateTime dateTo, string clientAcct)
        {
            try
            {
                return await (from item in _context.PurchaseOrders
                              where (item.Date >= dateFrom && item.Date <= dateTo) && item.ClientAccount.Equals(clientAcct)
                              select item).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<PurchaseOrder> GetPOByOrderId(string OrderId)
        {
            try
            {
                return await (from item in _context.PurchaseOrders
                              where item.OrderId.Equals(OrderId)
                              select item).SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<PurchaseOrder>> GetPOByStatus(string status, string clientAcct)
        {
            try
            {
                return await(from item in _context.PurchaseOrders
                             where item.Status.Equals(status) && item.ClientAccount.Equals(clientAcct)
                             select item).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<PurchaseOrder>> GetPOBySupplier(int Id)
        {
            try
            {
                return await (from item in _context.PurchaseOrders
                              where item.SupplierId.Equals(Id)
                              select item).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public async Task<IEnumerable<OrderItem>> GetOrderItemByOrderId(string OrderId)
        {
            try
            {
                return await _context.OrderItems.Where(x => x.OrderId == OrderId).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<OrderItem> GetOrderItemByOrderItemId(int Id)
        {
            try
            {
                return await _context.OrderItems.FindAsync(Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Save, Update & Delete

        public async Task<bool> Save(PurchaseOrder order)
        {
            try
            {
                bool isCreated = false;
                _context.PurchaseOrders.Add(order);
                var created = await _context.SaveChangesAsync();
                if (created > 0)
                    isCreated = true;

                return isCreated;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        public async Task<bool> Update(PurchaseOrder order)
        {
            try
            {
                bool isUpdated = false;
                _context.PurchaseOrders.Update(order);
                var updated = await _context.SaveChangesAsync();
                if (updated > 0)
                    isUpdated = true;

                return isUpdated;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> Delete(PurchaseOrder order)
        {
            try
            {
                bool isDeleted = false;
                _context.PurchaseOrders.Remove(order);
                var deleted = await _context.SaveChangesAsync();
                if (deleted > 0)
                    isDeleted = true;

                return isDeleted;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> SaveItem(OrderItem orderItem)
        {
            try
            {
                bool isCreated = false;
                _context.OrderItems.Add(orderItem);
                var created = await _context.SaveChangesAsync();
                if (created > 0)
                    isCreated = true;

                return isCreated;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public async Task<bool> UpdateItem(OrderItem orderItem)
        {
            try
            {
                bool isUpdated = false;
                _context.OrderItems.Update(orderItem);
                var updated = await _context.SaveChangesAsync();
                if (updated > 0)
                    isUpdated = true;

                return isUpdated;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
              

        public async Task<bool> DeleteItem(OrderItem orderItem)
        {
            try
            {
                bool isDeleted = false;
                _context.OrderItems.Remove(orderItem);
                var deleted = await _context.SaveChangesAsync();
                if (deleted > 0)
                    isDeleted = true;

                return isDeleted;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
