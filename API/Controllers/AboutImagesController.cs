
using API.Controllers;
using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using DtoLayer.AboutDtos;
using DtoLayer.AboutImageDtos;
using DtoLayer.CustomResponseDto;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutImagesController : CustomBaseController
    {
        private readonly IGenericService<AboutImage> _service;
        private readonly IMapper _mapper;
        
        
        public AboutImagesController(IGenericService<AboutImage> service, IMapper mapper)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _mapper = mapper;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultAboutImageDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultAboutImageDto>>.Success(values, 200));
        }

        
        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }
        
       
        [HttpPost]
        public async Task<IActionResult> Add(CreateAboutImageDto about)
        {
            var result = _mapper.Map<AboutImage>(about);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
       
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutImageDto about)
        {
            var result = _mapper.Map<AboutImage>(about);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
       
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(result);
            return Ok("Deleted Successfully");
        }
        
        
        
        
    }
}
