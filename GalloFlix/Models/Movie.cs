using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;
public class Movie
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } 

    [Required]
    [StringLength(100)]
    public string OriginalTitle { get; set; }

    [Required]
    [StringLength(8000)]
    public string Synopsis { get; set; } 

    [Required]
    [Column(TypeName = "Year")]
    public Int16 MovieYear { get; set; }

    [Required]
    public Int16 Duration { get; set; }

    [Required]
    public byte AgeRating { get; set; } = 0;

    [StringLength(200)]
    public string Image { get; set; } 

    [NotMapped]
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration).ToString(@"%h'h'mm'min'");
    } }
}