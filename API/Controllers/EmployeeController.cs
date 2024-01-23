using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.DiscountDtos;
using DtoLayer.EmployeeDtos;
using DtoLayer.EmployeeDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : CustomBaseController
    {
        private readonly IGenericService<Employee> _service;
        private readonly IMapper _mapper;


        public EmployeesController(IGenericService<Employee> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultEmployeeDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultEmployeeDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultEmployeeDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultEmployeeDto>.Success(values, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateEmployeeDto dto)
        {
            var result = _mapper.Map<Employee>(dto);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeDto dto)
        {
            var result = _mapper.Map<Employee>(dto);
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