using Entity.Abstract;

namespace Entity.Concrete;

public class RoomFeature : BaseClass
{
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public int FeatureId { get; set; }
    public Feature Feature { get; set; }
    
}