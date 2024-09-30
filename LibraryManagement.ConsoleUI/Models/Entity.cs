

namespace LibraryManagement.ConsoleUI.Models;
// abstract ortak özellikleri tutan class
public abstract class Entity
{
    public int Id { get; set; }

    protected Entity()
    {
        
    }

    protected Entity(int id) : this() //boş constructor çalışır
                                      //this():kendi sınıf içerisindeki boş constructor ı çalıştırır.
                                      //base() = bi üst sınıftaki
    {
        Id = id;
    }
}
