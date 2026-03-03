namespace Exzam_4;
public class Library
{
List<Book> books = [];
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DeleteBook(int Id)
    {
        var a = books.Find(n => n.Id == Id);
        if(a == null)
        {
            System.Console.WriteLine("Not found!");
            return;
        }
        books.Remove(a);
    }

    public void DisplayBooks()
    {
        books.ForEach(n => System.Console.WriteLine(n.Author + " " + n.Tittle));
    }

    public void SearchBookByTittle(string Tittle)
    {
        var a = books.Find(m => m.Tittle == Tittle);
        if(a == null)
        {
            System.Console.WriteLine("Not found!");
            return;
        }
        System.Console.Write(a.Id + " ");
        System.Console.Write(a.Author + " ");
        System.Console.WriteLine(a.Tittle);
    }

    public void SearchByAuthor(string Author)
    {
        var a = books.FindAll(m => m.Author == Author);
        if(a == null)
        {
            System.Console.WriteLine("Not found!");
            return;
        }
        a.ForEach(n => System.Console.WriteLine(n.Author + " " + n.Tittle));
    }

    public void UpdateBook(Book book)
    {
        foreach (var item in books)
        {
            if(item.Id == book.Id)
            {
                item.Author = book.Author;
                item.Tittle = book.Tittle;
                return;
            }
        }
    }
}
