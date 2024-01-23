using Entity.Abstract;

namespace Entity.Concrete;

public class About : BaseClass
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<AboutImage> AboutImages { get; set; }
    
    
}