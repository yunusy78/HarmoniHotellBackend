using Entity.Abstract;

namespace Entity.Concrete;

public class Category : BaseClass
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public List<Room> Rooms { get; set; }
    
}