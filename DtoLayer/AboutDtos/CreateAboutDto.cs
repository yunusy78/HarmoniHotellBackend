namespace DtoLayer.AboutDtos;

public class CreateAboutDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}