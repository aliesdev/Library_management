using Library_management.Interfaces;

namespace Library_management.Entities;

public class Library
{
    public List<Book> Books { get; set; }
    public List<Member> Members { get; set; }

    public Library(List<Book> books, List<Member> members)
    {
        Books = books;
        Members = members;
    }

    public void AddUser(IUser user)
    {

    }
    
}