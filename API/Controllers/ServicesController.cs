
using AutoMapper;
using Business.Abstract;
using DtoLayer.ServiceDtos;
using DtoLayer.CustomResponseDto;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : CustomBaseController
    {
        private readonly IGenericService<Service> _service;
        private readonly IMapper _mapper;
        
        
        public ServicesController(IGenericService<Service> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
       
       
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultServiceDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultServiceDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultServiceDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultServiceDto>.Success(values, 200));
        }
        
        
        [HttpPost]
        public async Task<IActionResult> Add(CreateServiceDto dto)
        {
            var result = _mapper.Map<Service>(dto);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
        [HttpPut]
        
        public async Task<IActionResult> Update(UpdateServiceDto dto)
        {
            var result = _mapper.Map<Service>(dto);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Service = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(Service);
            return Ok("Deleted Successfully");
        }
        
      
        [HttpGet("CategoriesAdmin")]
        public async Task<IActionResult> GetAllCategoriesAdmin()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        
        
    }
}
