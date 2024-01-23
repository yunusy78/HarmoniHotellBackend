
using API.Controllers;
using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using DtoLayer.AboutDtos;
using DtoLayer.CustomResponseDto;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : CustomBaseController
    {
        private readonly IGenericService<About> _aboutService;
        private readonly IMapper _mapper;
        
        
        public AboutsController(IGenericService<About> aboutService, IMapper mapper)
        {
            _aboutService = aboutService ?? throw new ArgumentNullException(nameof(aboutService));
            _mapper = mapper;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _aboutService.GetAllAsync();
            var values = _mapper.Map<List<ResultAboutDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultAboutDto>>.Success(values, 200));
        }

        
        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _aboutService.GetByIdAsync(id);
            return Ok(result);
        }
        
       
        [HttpPost]
        public async Task<IActionResult> Add(CreateAboutDto about)
        {
            var result = _mapper.Map<About>(about);
            await _aboutService.AddAsync(result);
            return Ok("Added Successfully");
        }
        
       
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto about)
        {
            var result = _mapper.Map<About>(about);
            await _aboutService.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
       
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _aboutService.GetByIdAsync(id);
            await _aboutService.RemoveAsync(result);
            return Ok("Deleted Successfully");
        }
        
        
        
        
    }
}
