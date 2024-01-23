
using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.RoomDtos;
using DtoLayer.FeatureDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : CustomBaseController
    {
        private readonly IGenericService<Room> _service;
        private readonly IMapper _mapper;
        
        
        public RoomsController(IGenericService<Room> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
       
      
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultRoomDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultRoomDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultRoomDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultRoomDto>.Success(values, 200));
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(CreateRoomDto Room)
        {
            var result = _mapper.Map<Room>(Room);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(UpdateRoomDto Room)
        {
            var result = _mapper.Map<Room>(Room);
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
        /*
        [HttpGet("CheckRoomCode")]
        
        public async Task<IActionResult> CheckRoomCode(string code)
        {
            var result = await _RoomService.CheckRoomCodeAsync(code);
            return Ok(result);
        }*/
        
        
        
        
    }
}
