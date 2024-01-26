﻿using System.ComponentModel.DataAnnotations;

public class EditReviewViewModel
{
    public int ServiceId { get; set; }

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }

    [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
    public string Comment { get; set; }
}
