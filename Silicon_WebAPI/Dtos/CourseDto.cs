﻿using System.ComponentModel.DataAnnotations;

namespace Silicon_WebAPI.Dtos
{
    public class CourseDto
    {
        [Required]
        public string Title { get; set; } = null!;
        public string? Price { get; set; }
        public string? DiscountPrice { get; set; }
        public string? Hours { get; set; }
        public bool IsBestSeller { get; set; } = false;
        public string? LikesInNumbers { get; set; }
        public string? LikesInProcent { get; set; }
        public string? Author { get; set; }
    }
}