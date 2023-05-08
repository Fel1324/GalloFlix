namespace GalloFlix.Models;
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public string OriginalTitle { get; set; }
    public string Synopsis { get; set; } 
    public Int16 MovieYear { get; set; }
    public Int16 Duration { get; set; }
    public byte AgeRating { get; set; }
    public string Image { get; set; } 
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration).ToString(@"%h'h'mm'min'");
    } }
}