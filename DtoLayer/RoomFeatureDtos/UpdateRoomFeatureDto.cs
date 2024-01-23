namespace DtoLayer.RoomFeatureDtos;

public class UpdateRoomFeatureDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int Price { get; set; }
    public int Capacity { get; set; }
    public int Size { get; set; }
    public bool Breakfast { get; set; }
    public bool Pets { get; set; }
    public bool Featured { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}