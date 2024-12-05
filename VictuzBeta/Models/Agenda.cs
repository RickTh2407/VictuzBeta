﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictuzBeta.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public virtual ICollection<Activity>? Activities { get; set; }
    }
}
