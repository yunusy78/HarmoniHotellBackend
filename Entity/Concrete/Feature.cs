using Entity.Abstract;

namespace Entity.Concrete;

public class Feature : BaseClass
{
    public string Title { get; set; }
    public string Icon { get; set; }
    public List<RoomFeature> RoomFeatures { get; set; }
    
}