using System;

namespace Exzam_4;

public interface ILibrary
{
void AddBook(Book book);
    void DisplayBooks();
    void UpdateBook(Book book);
    void DeleteBook(int Id);
    void SearchBookByTittle(string Tittle);
    void SearchByAuthor(string Author);
}
