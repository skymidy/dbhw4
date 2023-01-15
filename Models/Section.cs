using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBLesson3.Models;

public class Section
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; }

    [Required]
    public DateOnly CreationDate { get; set; }

    public List<Topic> Topics { get; set; } = new();

    [ForeignKey("Author")] public User? User { get; set; }
}