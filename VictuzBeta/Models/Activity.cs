using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictuzBeta.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? LocationDisplay { get; set; }
        [Required]
        public string? Category { get; set; }

        public virtual ICollection<Member>? Members { get; set; }

        public virtual Agenda? Agendas { get; set; }
        public virtual ICollection<Location>? Location { get; set; }

        public void AddToPlanner()
        {

        }
    } 
}
