namespace Entity.Abstract;

public abstract class BaseClass
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Status { get; set; } = false;
    
}