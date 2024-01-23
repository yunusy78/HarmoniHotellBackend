namespace DtoLayer.RoomImageDtos;

public class CreateRoomImageDto
{
    public int RoomId { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}