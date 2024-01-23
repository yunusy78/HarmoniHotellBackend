using Entity.Abstract;

namespace Entity.Concrete;

public class Contact : BaseClass
{ 
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    
}