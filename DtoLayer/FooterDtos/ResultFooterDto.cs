﻿namespace DtoLayer.FooterDtos;

public class ResultFooterDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}