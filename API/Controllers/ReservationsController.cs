using AutoMapper;
using Business.Abstract;
using DtoLayer.CustomResponseDto;
using DtoLayer.ReservationDtos;
using DtoLayer.ReservationDtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : CustomBaseController
    {
        private readonly IGenericService<Reservation> _service;
        private readonly IGenericService<Room> _roomService;
        private readonly IMapper _mapper;


        
        public ReservationsController(IGenericService<Reservation> service, IGenericService<Room> roomService, IMapper mapper)
        {
            _service = service;
            _roomService = roomService;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetAllAsync();
            var values = _mapper.Map<List<ResultReservationDto>>(result);
            return CreateActionResultInstance(CustomResponseDto<List<ResultReservationDto>>.Success(values, 200));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            var values = _mapper.Map<ResultReservationDto>(result);
            return CreateActionResultInstance(CustomResponseDto<ResultReservationDto>.Success(values, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateReservationDto dto)
        {
            dto.CreatedAt = DateTime.Now;
            dto.Status = false;
            var room = await _roomService.GetByIdAsync(dto.RoomId);
            int numberOfDays = (int)(dto.CheckOut - dto.CheckIn).TotalDays;
            dto.TotalPrice = room.Price * numberOfDays;
            dto.TotalGuest += dto.Adult+dto.Child+dto.Infant;
            var result = _mapper.Map<Reservation>(dto);
            await _service.AddAsync(result);
            return Ok("Added Successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateReservationDto dto)
        {
            var result = _mapper.Map<Reservation>(dto);
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