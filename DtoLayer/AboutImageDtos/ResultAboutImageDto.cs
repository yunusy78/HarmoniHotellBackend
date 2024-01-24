namespace DtoLayer.AboutImageDtos;

public class ResultAboutImageDto
{
    public int Id { get; set; }
    public int AboutId { get; set; }
    public string Image { get; set; }
    public string Imagewidth { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}