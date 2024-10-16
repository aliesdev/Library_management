using Library_management.Entities;

namespace Library_management.Interfaces;

public interface IBookManager
{
    void AddBook(Book book, Library library);
    void RemoveBook(Book book, Library library);
}