using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBLesson3.Models;

public class Message
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; }

    [Required]
    public DateOnly CreationDate { get; set; }

    [Required]
    public string Content { get; set; }

    [ForeignKey("Author")] public User? User { get; set; }
    
    [ForeignKey("Topic")] public Topic? Topic { get; set; }
}