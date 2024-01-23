using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.BannerDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : CustomBaseController
    {
        private readonly IGenericService<Banner> _service;
        private readonly IMapper _mapper;


        public BannersController(IGenericService<Banner> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultBannerDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultBannerDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultBannerDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultBannerDto>.Success(values, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateBannerDto dto)
        {
            var result = _mapper.Map<Banner>(dto);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto dto)
        {
            var result = _mapper.Map<Banner>(dto);
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