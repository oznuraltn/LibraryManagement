
using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public abstract class BaseRepository
{
    List<Author> authors = new List<Author>()
    {
        new Author(1,"Emile","Xola"),
        new Author(2,"Fyodor","Dostoyevski"),
        new Author(3,"Recaizade Mahmut"," Ekrem"),
        new Author(4,"Halide Edip","Adıvar"),
        new Author(5,"Ömer","Seyfettin"),
        new Author(6,"Ali","Koç"),
        new Author(7,"Vız vız","Ali")
    };


    List<Book> books = new List<Book>()
    {
    new Book(1,1,1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
    new Book(2,1,2,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
    new Book(3,2,2,"Kumarbaz","Bir öğretmenin hayatı",210,"2010 Ocak","9781234567892"),
    new Book(4,2,3,"Araba Sevdası","Arabayla alakası olmayan kitap",180,"1999 Ocak","9781234567838"),
    new Book(5,2,4,"Ateşten Gömlek","Kurtuluş savaşını anlatan kitap",120,"2001 Eylül","9781234567895"),
    new Book(6,2,5,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567899"),
    new Book(7,2,6,"Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak","9781234567807"),
    new Book(8,2,6,"16 Yıl Şampiyonluk","Hayal ürünüdür",255,"10 Eylül","9781234567800"),
    new Book(9,2,7,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567856"),
    };


    List<Category> categories = new List<Category>()
    {
        new Category(1,"dünya klasikleri"),
        new Category(2,"türk klasikleri"),
        new Category(3,"bilim kurgu")
    };

    private List<Member> members = new List<Member>()
    {
        new Member
        {
            Id=1,
            Age= 25,
            Name = "Eva",
            Surname = "Neva"
        },
        new Member
        {
            Id=2,
            Name ="Sosyal Ankastre 1",
            Surname = "Sosyal Ankastre 2",
            Age = 25,
        }
    };

    public List<Book> Books()
    {
        return books;
    }

    public List<Category> Categories()
    {
        return categories;
    }

    public List<Author> Authors()
    {
        return authors;
    }

    private List<Member> Members()
    {
        return members; 
    }
        


}
