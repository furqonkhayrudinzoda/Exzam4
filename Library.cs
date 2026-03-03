namespace Exzam_4;
public class Library:Book
{
List<string> list = new List<string>();
public void AddBook(string book)
    {
        list.Add(book);
    }
    public void DisplayBooks(string title)
    {
        list.Add(title);
    }
    public void UpdateBook(string book)
    {
      
    }
    public void DeleteBook(string title)
    {
         list.Remove(title);
    }
    public void SearchByTitle()
    {
       
    }
}
