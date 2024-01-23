
using AutoMapper;
using Business.Abstract;
using DtoLayer.CategoryDtos;
using DtoLayer.CustomResponseDto;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly IGenericService<Category> _service;
        private readonly IMapper _mapper;
        
        
        public CategoriesController(IGenericService<Category> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
       
       
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultCategoryDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultCategoryDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultCategoryDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultCategoryDto>.Success(values, 200));
        }
        
        
        [HttpPost]
        public async Task<IActionResult> Add(CreateCategoryDto category)
        {
            var result = _mapper.Map<Category>(category);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
        [HttpPut]
        
        public async Task<IActionResult> Update(UpdateCategoryDto category)
        {
            var result = _mapper.Map<Category>(category);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(category);
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
