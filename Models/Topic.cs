using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBLesson3.Models;

public class Topic
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; }

    [Required]
    public DateOnly CreationDate { get; set; }

    public List<Message> Messages { get; set; } = new();

    [ForeignKey("Author")] public User? User { get; set; }

    [ForeignKey("SectionId")] public Section? Section { get; set; }
}