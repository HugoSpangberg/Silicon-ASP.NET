﻿
namespace Infrastructure.Entities;

public class CourseEntity
{
    public int Id { get; set; }
    public string imageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Hours { get; set; }
    public bool IsBestSeller { get; set; }
    public decimal LikesInNumbers { get; set; }
    public decimal LikesInProcent { get; set; }
    public string? Author { get; set; }
}
