namespace DtoLayer.CategoryDtos;

public class CreateCategoryDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}