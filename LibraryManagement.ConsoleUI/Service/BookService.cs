

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service;

public class BookService
{
    BookRepository bookRepository = new BookRepository();

    public void GetAll()
    {
        List<Book> books = bookRepository.GetAll();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetById(int id)
    {
        Book? book = bookRepository.GetById(id);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız Idye göre kitap bulunamadı : {id}");
            return;
        }
        Console.WriteLine(book);
    }

    public void Remove(int id)
    {
        Book? deletedBook = bookRepository.Remove(id);
        if (deletedBook is null)
        {
            Console.WriteLine("Aradığınız kitap bulunamadı");
            return;
        }
        Console.WriteLine(deletedBook);
    }

    public void GetBookByISBN(string isbn)
    {
        Book? book = bookRepository.GetBookByISBN(isbn);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız ISBN numarasına göre kitap bulunamadı {isbn}");
            return;
        }

        Console.WriteLine(book);
    }

    public void Add(Book book)
    {
        BookIdBusinessRules(book.Id);
        BookISBNBusinessRules(book.ISBN);
        Book created = bookRepository.Add(book);
        Console.WriteLine("Kitap eklendi : ");
        Console.WriteLine(created);
    }

    public void GetAllBooksByPageSizeFilter(int min, int max)
    {
        List<Book> books = bookRepository.GetAllBooksByPageSizeFilter(min, max);
    }

    public void GettAllBooksByTitleContains(string text)
    {
        List<Book> books = bookRepository.GetAllBooksByTitleContains(text);
        books.ForEach(book => Console.WriteLine(book));
        //foreach (Book book in books)
        //{
        //    Console.WriteLine(book);
        //}
    }

    public void GetAllBookOrderByTitleDescending()
    {
        List<Book> books = bookRepository.GetAllBookOrderByDescendingTitle();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }

    }

    public void GetBookMaxPageSize()
    {
        Book MaxPageSize = bookRepository.GetBookMaxPageSize();
        Console.WriteLine(MaxPageSize);
    }

    public void GetBookMinPageSize()
    {
        Book MinPageSize = bookRepository.GetBookMinPageSize();
        Console.WriteLine(MinPageSize);
    }

    public void GetDetails()
    {
        List<BookDetailDto> books = bookRepository.GetDetails();
        foreach (BookDetailDto bookDetail in books)
        {
            Console.WriteLine(bookDetail);
        }
    }

    public void GetDetailsV2()
    {
        List<BookDetailDto> books = bookRepository.GetDetailsV2();
        foreach (BookDetailDto bookDetail in books)
        {
            Console.WriteLine(bookDetail);
        }
    }

    public void GetAllBooksAndAuthorDetails()
    {
        List<BookDetailDto> details = bookRepository.GetAllAuthorAndBookDetails();
        details.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByCategoryId(int categoryId)
    {
        List<BookDetailDto> details = bookRepository.GetAllDetailsByCategoryId(categoryId);
        details.ForEach(x => Console.WriteLine(x));  
        
    }

    private void BookIdBusinessRules(int id)
    {
        Book? getByIdBook = bookRepository.GetById(id);
        if (getByIdBook != null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın Id Alanı Benzersiz olmalıdır: {id}");
            return;
        }
    }

    private void BookISBNBusinessRules(string isbn)
    {
        Book? getBookByISBN = bookRepository.GetBookByISBN(isbn);
        if (getBookByISBN is not null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın ISBN Alanı Benzersiz olmalıdır: {isbn}");
            return;
        }
    }


}
