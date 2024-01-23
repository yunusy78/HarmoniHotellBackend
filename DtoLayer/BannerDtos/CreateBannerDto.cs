namespace DtoLayer.BannerDtos;

public class CreateBannerDto
{
    public string Title { get; set; }
    public string? Icon { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
    
}