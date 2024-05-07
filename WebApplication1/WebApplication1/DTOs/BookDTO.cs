namespace WebApplication1.DTOs;

public class BookDTO
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public List<GenreDTO> GenresList { get; set; }
}

public class GenreDTO
{
    public string genre { get; set; }
}