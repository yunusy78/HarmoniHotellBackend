namespace DtoLayer.BannerDtos;

public class GetBannerDto
{
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Icon { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}