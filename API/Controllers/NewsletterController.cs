using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.DiscountDtos;
using DtoLayer.NewsletterDtos;
using DtoLayer.NewsletterDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewslettersController : CustomBaseController
    {
        private readonly IGenericService<Newsletter> _service;
        private readonly IMapper _mapper;


        public NewslettersController(IGenericService<Newsletter> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultNewsletterDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultNewsletterDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultNewsletterDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultNewsletterDto>.Success(values, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateNewsletterDto dto)
        {
            var result = _mapper.Map<Newsletter>(dto);
            result.CreatedAt = DateTime.Now;
            result.Status = true;
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateNewsletterDto dto)
        {
            var result = _mapper.Map<Newsletter>(dto);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dto = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(dto);
            return Ok("Deleted Successfully");
        }

    }

}