using Microsoft.AspNetCore.Mvc;
using OrderService.API.Models;
using OrderService.Domain.Aggregates;  // ✅ Yeni using

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            try
            {
                // Order oluştur
                var order = Order.Create(request.UserId, request.ProductId, request.Quantity, request.Price);

                return Ok(new
                {
                    OrderId = order.Id,
                    Message = "Order created successfully",
                    UserId = order.UserId,
                    ProductId = order.ProductId,
                    Quantity = order.Quantity,
                    Price = order.Price,
                    Status = order.Status.ToString()
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            return Ok(new { OrderId = id, Status = "Created" });
        }
    }
}