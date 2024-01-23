namespace DtoLayer.MessageDtos;

public class CreateMessageDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}