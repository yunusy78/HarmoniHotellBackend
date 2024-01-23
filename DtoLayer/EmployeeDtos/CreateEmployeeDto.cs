namespace DtoLayer.EmployeeDtos;

public class CreateEmployeeDto
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public string FacebookUrl { get; set; }
    public string TwitterUrl { get; set; }
    public string InstagramUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
    
}