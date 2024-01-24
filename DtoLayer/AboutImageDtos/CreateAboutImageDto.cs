namespace DtoLayer.AboutImageDtos;

public class CreateAboutImageDto
{
    public int AboutId { get; set; }
    public string Image { get; set; }
    public string Imagewidth { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}