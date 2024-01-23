namespace DtoLayer.NewsletterDtos;

public class CreateNewsletterDto
{
    public string Email { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}