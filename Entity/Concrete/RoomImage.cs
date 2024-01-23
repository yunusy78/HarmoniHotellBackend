using Entity.Abstract;

namespace Entity.Concrete;

public class RoomImage : BaseClass
{
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public string Image { get; set; }
    
}