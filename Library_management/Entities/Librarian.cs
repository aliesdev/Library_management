using Library_management.Interfaces;

namespace Library_management.Entities;

public class Librarian : IUser, IBookManager
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void AddBook(Book book, Library library)
    {
        throw new NotImplementedException();
    }

    public void DisplayUser()
    {
        throw new NotImplementedException();
    }

    public void RemoveBook(Book book, Library library)
    {
        throw new NotImplementedException();
    }
}