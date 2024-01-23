namespace DtoLayer.FeatureDtos;

public class CreateFeatureDto
{
    public string Title { get; set; }
    public string? Icon { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
    
}