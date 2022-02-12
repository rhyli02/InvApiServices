using InvApiServices.Models.Context;
using InvApiServices.Models.ViewModel;
using InvApiServices.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService _service;

        public PurchaseOrderController(IPurchaseOrderService service)
        {
            _service = service;
        }

        // GetAllPOByClientAccount: api/<PurchaseOrderController>
        [HttpGet("{clientAcct}")]
        public async Task<IEnumerable<POViewModel>> GetAllPOByClientAccount(string clientAcct)
        {
            return await _service.GetAllPOByClient(clientAcct);
        }

        // GetPOByOrderId api/<PurchaseOrderController>/5
        [HttpGet("{orderId}")]
        public async Task<POViewModel> GetPOByOrderId(string orderId)
        {
            return await _service.GetPOByOrderId(orderId);
        }


        // GET api status/<PurchaseOrderController>/5
        [HttpGet("{status}/{clientAcct}")]
        public async Task<IEnumerable<POViewModel>> GetPOByOrderId(string status, string clientAcct)
        {
            return await _service.GetPOByStatus(status, clientAcct);
        }


        [HttpGet("{dateFrom}/{dateTo}/{clientAcct}")]
        public async Task<IEnumerable<POViewModel>> GetPOByOrderId(DateTime dateFrom, DateTime dateTo, string clientAcct)
        {
            return await _service.GetPOByDateRange(dateFrom, dateTo, clientAcct);
        }
        // POST api/<PurchaseOrderController>
        [HttpPost]
        public async Task<IActionResult> AddPurchaseOrder(POViewModel  collect)
        {
            try
            {
                if (collect == null)
                    return BadRequest();

                string orderId = _service.GenerateOrderId(collect.ClientAccount);
                collect.OrderId = orderId;
                bool isSaved = await _service.Save(collect);

               
                if (isSaved)
                {
                    var response = await _service.GetPOByOrderId(orderId);

                    return CreatedAtAction(nameof(GetPOByOrderId),
                new { orderId = response.OrderId }, response);
                }else
                {
                    return StatusCode(StatusCodes.Status501NotImplemented,
                  "Error - Record Not saved.");
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new purchase order");
            }
        }

        // PUT api/<PurchaseOrderController>/5
        [HttpPut]
        public async Task<IActionResult> Put( POViewModel collect)
        {
            try
            {
                if (collect == null)
                    return BadRequest();

                bool isSaved = await _service.Update(collect);
                if (isSaved)
                {
                    var response = await _service.GetPOByOrderId(collect.OrderId);
                    return CreatedAtAction(nameof(GetPOByOrderId),
                             new { id = response.Id }, response);
                }
                else
                {
                    return StatusCode(StatusCodes.Status304NotModified,
                  "Error - Update not Successful.");
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error Updating existing purchase order");
            }
        }

        // DELETE api/<PurchaseOrderController>/5
        [HttpDelete("{orderId}")]
        public async void Delete(string orderId)
        {
            try
            {
               
                bool isSaved = await _service.Delete(orderId);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
