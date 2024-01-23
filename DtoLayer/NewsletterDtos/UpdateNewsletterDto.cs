namespace DtoLayer.NewsletterDtos;

public class UpdateNewsletterDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}