using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.DiscountDtos;
using DtoLayer.FeatureDtos;
using DtoLayer.FeatureDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : CustomBaseController
    {
        private readonly IGenericService<Feature> _service;
        private readonly IMapper _mapper;


        public FeaturesController(IGenericService<Feature> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultFeatureDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultFeatureDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultFeatureDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultFeatureDto>.Success(values, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateFeatureDto dto)
        {
            var result = _mapper.Map<Feature>(dto);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto dto)
        {
            var result = _mapper.Map<Feature>(dto);
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