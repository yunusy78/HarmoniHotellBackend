﻿namespace DtoLayer.RoomImageDtos;

public class GetRoomImageDto
{
    
    public int Id { get; set; }
    public int RoomId { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}