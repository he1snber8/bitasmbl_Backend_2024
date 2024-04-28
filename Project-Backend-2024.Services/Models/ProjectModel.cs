﻿namespace Project_Backend_2024.Services.Models;

public class ProjectModel : IEntityModel, IBasicModel
{
    public int Id { get; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
}
