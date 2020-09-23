using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.API.DTO;
using Shop.Entities;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ShopContext _context;

        public OrdersController(ShopContext context)
        {
            _context = context;
        }
        // GET : api/Orders/ByCustomerId
        [HttpGet("ByCustomerId/{customerId}")]
        public IEnumerable<Order> GetOrdersById(int customerId)
        {
            return _context.Order.Where(o => o.CustomerId == customerId);
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return await _context.Order.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            
            var order = await _context.Order.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpGet("Position/{id}")]
        public async Task<ActionResult<OrderPosition>> GetPosition(int id)
        {

            var orderposition = await _context.OrderPosition.FindAsync(id);

            if (orderposition == null)
            {
                return NotFound();
            }

            return orderposition;
        }

        [HttpGet("Position/ByOrderId/{orderId}")]
        public IEnumerable<OrderPosition> GetPositionById(int orderId)
        {
            return _context.OrderPosition.Include(o => o.Product).Where(o => o.OrderId == orderId);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(CreateOrderDTO orderDTO)
        {
            Order order = new Order(orderDTO.Date, orderDTO.CustomerId);
            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        [HttpPost("Position")]
        public async Task<ActionResult<OrderPosition>> PostOrderPosition(CreateOrderPositionDTO orderpositionDTO)
        {
           var orderposition = new OrderPosition(orderpositionDTO.OrderId,orderpositionDTO.ProductId,orderpositionDTO.Quantity);
            _context.OrderPosition.Add(orderposition);
            _context.SaveChanges();
            return CreatedAtAction("GetPosition", new { id = orderposition.Id }, orderposition);

        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Order.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        // DELETE: api/Orders/5
        [HttpDelete("Position/{id}")]
        public async Task<ActionResult<OrderPosition>> DeletePosition(int id)
        {
            var orderposition = await _context.OrderPosition.FindAsync(id);
            if (orderposition == null)
            {
                return NotFound();
            }

            _context.OrderPosition.Remove(orderposition);
            await _context.SaveChangesAsync();

            return orderposition;
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
