﻿namespace DtoLayer.FeatureDtos;

public class UpdateFeatureDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Icon { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Status { get; set; }
}