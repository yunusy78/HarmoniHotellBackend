namespace DtoLayer.AboutDtos;

public class UpdateAboutDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}