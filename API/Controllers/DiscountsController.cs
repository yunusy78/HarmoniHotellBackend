
using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.DiscountDtos;
using DtoLayer.FeatureDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : CustomBaseController
    {
        private readonly IGenericService<Discount> _service;
        private readonly IMapper _mapper;
        
        
        public DiscountsController(IGenericService<Discount> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
       
      
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultDiscountDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultDiscountDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultDiscountDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultDiscountDto>.Success(values, 200));
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(CreateDiscountDto discount)
        {
            var result = _mapper.Map<Discount>(discount);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(UpdateDiscountDto discount)
        {
            var result = _mapper.Map<Discount>(discount);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var discount = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(discount);
            return Ok("Deleted Successfully");
        }
        /*
        [HttpGet("CheckDiscountCode")]
        
        public async Task<IActionResult> CheckDiscountCode(string code)
        {
            var result = await _discountService.CheckDiscountCodeAsync(code);
            return Ok(result);
        }*/
        
        
        
        
    }
}
