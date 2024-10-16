using Library_management.Interfaces;

namespace Library_management.Entities;

public class Member : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public List<Book> BorrowedBooks { get; private set; }

    public Member(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public void DisplayUser()
    { 
    }
}