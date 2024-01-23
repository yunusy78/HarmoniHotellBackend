using Entity.Abstract;

namespace Entity.Concrete;

public class Room : BaseClass
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int Price { get; set; }
    public int Capacity { get; set; }
    public int Size { get; set; }
    public bool Featured { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<RoomFeature> RoomFeatures { get; set; }
    public List<RoomImage> RoomImages { get; set; }
    public List<Reservation> Reservations { get; set; }
    
}