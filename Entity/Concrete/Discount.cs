using Entity.Abstract;

namespace Entity.Concrete;

public class Discount : BaseClass
{
    public string Title { get; set; }
    public int Rate { get; set; }
    public string Code { get; set; }
    public string Image { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    
}