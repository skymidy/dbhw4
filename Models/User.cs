using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBLesson3.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; }

    public List<Section> Sections { get; set; } = new();

    public List<Topic> Topics { get; set; } = new();

    public List<Message> Messages { get; set; } = new();
}