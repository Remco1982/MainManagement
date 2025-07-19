using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Interfaces.Services;
using StockManagement.DataContracts;

namespace StockManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerViewModel>>> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerViewModel>> GetById(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateCustomerModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _customerService.CreateAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] UpdateCustomerModel model)
        {
            if (id != model.Id)
                return BadRequest("ID mismatch.");

            var exists = await _customerService.ExistsAsync(id);
            if (!exists)
                return NotFound();

            await _customerService.UpdateAsync(model);
            return NoContent();
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await _customerService.ExistsAsync(id);
            if (!exists)
                return NotFound();

            await _customerService.DeleteAsync(id);
            return NoContent();
        }
    }
}
