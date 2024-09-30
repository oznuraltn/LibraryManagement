namespace LibraryManagement.ConsoleUI.Models;

public sealed class Author : Entity
{
    public Author()
    {
       
    }
    public Author(int id,string name, string surname) : base(id)   //yukardaki sınıftaki constructor a ulaş
    {
        Name = name;
        Surname = surname;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
}

