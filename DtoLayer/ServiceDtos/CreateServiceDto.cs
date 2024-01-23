namespace DtoLayer.ServiceDtos;

public class CreateServiceDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}