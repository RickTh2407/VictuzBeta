﻿using System.ComponentModel.DataAnnotations;

namespace VictuzBeta.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Room { get; set; }
        public virtual ICollection<Activity>? Activities { get; set; }

    }
}