namespace Exzam_4;

public class Book
{public int Id { get; set; }
    public string? Tittle { get; set; }
    public string? Author { get; set; }
    public Book(int Id, string Name, string Author)
    {
        this.Id = Id;
        this.Tittle = Name;
        this.Author = Author;
    }
}
