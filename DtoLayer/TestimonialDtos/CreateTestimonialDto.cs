namespace DtoLayer.TestimonialDtos;

public class CreateTestimonialDto
{
    public string Name { get; set; }
    public string Job { get; set; }
    public string Image { get; set; }
    public string Comment { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}