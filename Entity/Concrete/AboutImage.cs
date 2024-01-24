using Entity.Abstract;

namespace Entity.Concrete;

public class AboutImage : BaseClass
{
    public int AboutId { get; set; }
    public About About { get; set; }
    public string Image { get; set; }
    public string Imagewidth { get; set; }
    
}