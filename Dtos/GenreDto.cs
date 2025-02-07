﻿using System.ComponentModel.DataAnnotations;

namespace WebAssignment_Quiz_.Dtos
{
    public class GenreDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
    }
}
