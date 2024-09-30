

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using System.Linq;

namespace LibraryManagement.ConsoleUI.Repository;

public class BookRepository : BaseRepository, IBookRepository
{

    private List<Book> books; // yönetimi metod üzerinden yapmak için private
    private List<Category> categories; 
    private List<Author> authors;
    public BookRepository()
    {
        books = Books();
        categories = Categories();
    }


    public List<Book> GetAll()
    {
        return books;
    }

    public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
    {
        //Geleneksel Yöntem

        //    List<Book> filteredBooks = new List<Book>();

        //    foreach (Book book in books)
        //    {
        //        if (book.PageSize <= max && book.PageSize >= min)
        //        {
        //            filteredBooks.Add(book);
        //        }


        // LINQ GELENEKSEL
        //List<Book> result = (from b in books
        //                    where b.PageSize<= max && b.PageSize>=min
        //                    select b).ToList();
        //return result;  

        //List<Book> result = book,Where(b => b.PageSize <= max && b.PageSize >= min).ToList());

        List<Book> result = books.FindAll(b => b.PageSize <= max && b.PageSize >= min);   //zamandan kazanmak,daha mantıklı
        return result;
    }

    //    return filteredBooks;   
    //}

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(x => x.PageSize);
        return total;
    }

    public List<Book> GetAllBooksByTitleContains(string text)
    {
        List<Book> filteredBooks = new List<Book>();

        //foreach (Book book in books)
        //{
        //    if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        filteredBooks.Add(book);
        //    }
        //}
        //return filteredBooks;


        List<Book> result = books.Where(a => a.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase)).ToList();   //ucu açık istediğin veriyi döner
                                                                                                                              //List<Book> result = books.FindAll(a => a.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase)          kesinlikle liste döndürür.
        return result;

    }

    public Book? GetBookByISBN(string isbn)
    {
        //Book book1 = null;

        //foreach (Book item in books)
        //{
        //    if(item.ISBN == isbn)
        //    {
        //        book1 = item;              
        //    }
        //}

        //if (book1 == null)
        //{
        //    return null;
        //}
        //return book1;


        //return book1 ?? book;
        //return Book == null ? null : book1;
        //-------------------------------------------

        //Book book = (from b in books where b.ISBN == isbn select b).First();

        //Book book =books.Where(x>= x.ISBN == isbn).FirstOrDefault();  //SingleOrDefault  bir tane uniq olması beklenen

        Book book = books.SingleOrDefault(x => x.ISBN == isbn);
        return book;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(int id)
    {
        Book? book1 = null;
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book1 = book;
            }
        }

        if (book1 == null)
        {
            return null;
        }
        return book1;
    }

    public Book? Remove(int id)
    {
        Book? deletedBook = GetById(id);

        if (deletedBook is null)
        {
            return null;
        }

        books.Remove(deletedBook);
        return deletedBook;
    }

    public List<Book> GetAllBookOrderByDescendingTitle()
    {
        List<Book> orderedBooks = books.OrderByDescending(b => b.Title).ToList();
        return orderedBooks;
    }


    public Book GetBookMaxPageSize()
    {
        Book maxPageSize = books.OrderBy(x => x.PageSize).LastOrDefault();
        //Book book =books.OrderBy(x => x.PageSize).LastOrDefault();
        //return book;
        return maxPageSize;
    }

    public Book GetBookMinPageSize()
    {
        Book maxPageSize = books.OrderBy(x => x.PageSize).FirstOrDefault();
        return maxPageSize;
    }

    public List<BookDetailDto> GetDetails()
    {
        var result =
            from b in books
            join c in categories
            on b.CategoryId equals c.Id
            select new BookDetailDto(
                Id: b.Id,
                CategoryName: c.Name,
                "",
                Title: b.Title,
                Description: b.Description,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
                );

        return result.ToList();
    }

    public List<BookDetailDto> GetDetailsV2()
    {
        List<BookDetailDto> details =
            books.Join(categories,

            b => b.CategoryId,
            c => c.Id,
            (book, category) => new BookDetailDto(
                Id: book.Id,
                CategoryName: category.Name,
                "",
                Title: book.Title,
                Description: book.Description,
                PageSize: book.PageSize,
                PublishDate: book.PublishDate,
                ISBN: book.ISBN
                )
            ).ToList();

        return details;
    }

    public List<BookDetailDto> GetAllAuthorAndBookDetails()
    {
        var result =
            from b in books
            join c in categories on b.CategoryId equals c.Id
            join a in authors on b.AuthorId equals a.Id

            select new BookDetailDto(
                Id: b.Id,
                Title: b.Title,
                CategoryName: c.Name,
                AuthorName: $"{a.Name} {a.Surname}",
                Description: b.Description,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
                );
        return result.ToList();
    }

    public List<BookDetailDto>GetAllDetailsByCategoryId(int categoryId)
        {
        var result =
            from b in books
            where b.CategoryId == categoryId // ilk filtreleyip sonra dönüştürmek daha mantıklı 
            join c in categories on b.CategoryId equals c.Id
            join a in authors on b.AuthorId equals a.Id

            select new BookDetailDto(
                Id: b.Id,
                Title: b.Title,
                CategoryName: c.Name,
                AuthorName: $"{a.Name} {a.Surname}",
                Description: b.Description,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
                );
        return result.ToList();

    }

    public List<Book> GetAllBookOrderByTitle()
    {
        throw new NotImplementedException();
    }

    public List<string> GetAllTitles()
    {
        List<string> titles =
           books.Select(x => x.Title).ToList();

        return titles;
    }
}
