﻿namespace DtoLayer.NewsletterDtos;

public class ResultNewsletterDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}