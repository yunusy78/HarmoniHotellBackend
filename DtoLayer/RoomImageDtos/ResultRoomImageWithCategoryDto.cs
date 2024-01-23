namespace DtoLayer.RoomImageDtos;

public class ResultRoomImageWithCategoryDto
{
    public int ProductId { get; set; }
    public int RoomId { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}