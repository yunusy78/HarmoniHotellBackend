
using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.MessageDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : CustomBaseController
    {
        private readonly IGenericService<Contact> _service;
        private readonly IMapper _mapper;
        
        
        
        public ContactsController(IGenericService<Contact> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
       
        
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultMessageDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultMessageDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultMessageDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultMessageDto>.Success(values, 200));
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(CreateMessageDto contact)
        {
            var result = _mapper.Map<Contact>(contact);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(UpdateMessageDto contact)
        {
            var result = _mapper.Map<Contact>(contact);
            await _service.UpdateAsync(result);
            return Ok("Updated Successfully");
        }
        
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var contact = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(contact);
            return Ok("Deleted Successfully");
        }
        
        
        
        
    }
}
