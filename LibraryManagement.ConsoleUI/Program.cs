// (Record) Kitap -> Id , Title , Description , PageSize , PublishDate , ISBN , Stok
// (Record) Author -> Id , Name , Surname 
// (Class) Category -> Id , Name

// Category eklerken -> Id veya Name alanı benzersiz olmalı
// Author eklerken Id(name surname)

//Kitaplar listesi oluşturunuz
//Yazarlar listesi oluşturunuz
//Kategoriler listesi oluşturunuz

//Yazarları ekrana bastıran kodu yazınız
//Kitapları ekrana bastıran kodu yazınız
//Kategorileri ekrana bastıran kodu yazınız

//Kitapları sayfa sayısına göre filtreleyen kodu yazınız
//Kütüphanedeki tüm kitapların sayfa sayısı toplamını hesaplayan kodu yazınız
//Kitap başlığına göre filtreleme işlemleri yapınız
//Kitap ISBN numarasına göre ilgili kitabı getiriniz

//Kitaplar listesine yeni bir kitap ekleyip eklendikten sonra listeyi ekran çıktısı olarak yazınız
//(verileri kullanıcıdan alınız)
// *Kitap eklerken Id si veya ISBN numarası daha önceki eklenen kitaplarda var ise "Benzersiz bir kitap girmeniz gerektirmektedir." yazısı çıksın 

//Kullanıcı bir Id girdiği zaman o Id ye gören kitabı silen ve yeni listeyi ekrana yazdıran kodu yazınız

//Kullanıcıdan ilk başta Id değeri alıp arama yaptıktan sonra eğer o Id ye ait bir kitap yoksa "İlgili Id ye ait bir kitap bulunamadı."desin
//*Güncellenecek olan değerler kullanıcıdan alınacak.

// KUllanıcıdan bir kitap almasını isteyen kodu yazınız
// Eğer o kitap stokta varsa kitap alındı yazısı çıksın.1 tane varsa o kitap alınsın ve 0 olursa listeden silinsin


//Prime örnekler
// BookDetail adında bir record oluşturup şu değerler listelenecek:
// Kitap Id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN , Yazar Adı, Kategori Adı

// Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği giriniz.



using LibraryManagement.ConsoleUI.Service;
using System.ComponentModel;



//List<Author> authors = new List<Author>()
//{
//    new Author(1,"Emile","Xola"),
//    new Author(2,"Fyodor","Dostoyevski"),
//    new Author(3,"Recaizade Mahmut"," Ekrem"),
//    new Author(4,"Halide Edip","Adıvar"),
//    new Author(5,"Ömer","Seyfettin"),
//    new Author(6,"Ali","Koç"),
//    new Author(7,"Vız vız","Ali")
//};

//List<Category> categories = new list<category>()
//{
//    new Category(1,"dünya klasikleri"),
//    new Category(2,"türk klasikleri"),
//    new Category(3,"bilim kurgu")
//};

//Console.WriteLine("Kitapları Listele: ");
//Console.WriteLine("------------------------------ ");

//foreach (Book book in books)
//{
//    Console.WriteLine(book);
//}

//Console.WriteLine("Yazarları Listele: ");
//Console.WriteLine("(\"------------------------------ ");

//foreach (Author author in authorList)
//{
//    Console.WriteLine(author);
//}

//Console.WriteLine("Kategorileri Listele: ");
//Console.WriteLine("(\"------------------------------");

//foreach (Category category in categoryList)
//{
//    Console.WriteLine(category);
//}

//GetBookByISBN();

//GetAllBooksByTitleContains();
//PageSizeTotalCalculator();

//GetAllBooksByPageSizeFilter();
//GetAllBooks();
//GetAllCategories();
//GetAllAuthors();


//AddBook();
//AddAuthor();


BookService bookService = new BookService();
bookService.GetAll();
//bookService.GetById(100);
//bookService.GetBookByISBN(null);
//bookService.GetAllBooksByPageSizeFilter(100, 250);
//bookService.GetAllBookOrderByTitleDescending();
//bookService.GetBookMaxPageSize();
//bookService.GetDetails();
bookService.GetAllDetailsByCategoryId(2);



//void GetAllBooksByTitleContains()
//{
//    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
//    string text = Console.ReadLine();

//    foreach (Book book in books)
//    {
//        if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
//        {
//            Console.WriteLine(book);
//        }
//    }
//}


//void GetAllBooks()
//{
//    PrintAyirac("Kitapları Listele: ");

//    foreach (Book book in books)
//    {
//        Console.WriteLine(book);
//    }
//}

//void GetAllCategories()
//{
//    PrintAyirac("Kategorileri Listele: ");

//    foreach (Category category in categories)
//    {
//        Console.WriteLine(category);
//    }
//}

//void GetAllAuthors()
//{
//    PrintAyirac("Yazarları Listele: ");

//    foreach (Author author in authors)
//    {
//        Console.WriteLine(author);
//    }
//}

//void PrintAyirac(string metin)
//{
//    Console.WriteLine(metin);
//    Console.WriteLine("---------------");
//}



//Book GetBookInputs2()
//{
//    Console.WriteLine("Lütfen kitap id sini giriniz: ");
//    int id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
//    string title = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap açıklamasını giriniz: ");
//    string description = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
//    int pageSize = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap yayımlanma tarihini giriniz: ");
//    string publishDate = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
//    string isbn = Console.ReadLine();

//    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
//    return book;
//}


//void GetBookInputs(out int id,
//    out string title,
//    out string description,
//    out int pageSize,
//    out string publishDate,
//    out string isbn)
//{
//    Console.WriteLine("Lütfen kitap id sini giriniz: ");
//    id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
//    title = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
//    description = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
//    pageSize = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
//    publishDate = Console.ReadLine();

//    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
//    isbn = Console.ReadLine();
//}

//bool AddBookValidator(Book book)
//{
//    bool isUnique = true;

//    foreach (Book item in books)
//    {
//        if (item.Id == book.Id || item.ISBN == book.ISBN)
//        {
//            isUnique = false;
//            break;
//        }
//    }

//    return isUnique;
//}

//void AddBook()
//{
//    PrintAyirac("Kitap Ekleme: ");
//    //---------------1.yöntem-----------
//    //int id;
//    //string title;
//    //string description;
//    //int pageSize;
//    //string publishDate;
//    //string isbn;
//    //GetBookInputs(out id, out tittle, out description, out pageSize, out publishDate, out isbn);

//    //Console.WriteLine("Lütfen kitap id sini giriniz: ");
//    //int id = Convert.ToInt32(Console.ReadLine());

//    //Console.WriteLine("Lütfen kitap başlığını giriniz: ");
//    //string title = Console.ReadLine();

//    //Console.WriteLine("Lütfen kitap açıklamasını giriniz: ");
//    //string description = Console.ReadLine();

//    //Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
//    //int pageSize = Convert.ToInt32(Console.ReadLine());

//    //Console.WriteLine("Lütfen kitap yayınlanma tarihini giriniz: ");
//    //string publishDate = Console.ReadLine();

//    //Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
//    //string isbn = Console.ReadLine();

//    Book book = GetBookInputs2();
//    bool isUnique = AddBookValidator(book);

//    //Benzersiz değilse
//    if (!isUnique)
//    {
//        Console.WriteLine("Girmiş olduğunuz kitap benzersiz değildir.");
//        return;
//    }
//    books.Add(book);
//    GetAllBooks();
//}

//bool AddAuthorValidator(Author author)
//{
//    bool isUnique = true;

//    foreach (Author item in authors)
//    {
//        if (item.Id == author.Id || (item.Name == author.Name && item.Surname == author.Surname))
//        {
//            isUnique = false;
//            break;
//        }
//    }

//    return isUnique;
//}


//Author GetAuthorInputs()
//{
//    Console.WriteLine("Lütfen yazar id si giriniz.");
//    int id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen yazarın ismini giriniz: ");
//    string name =Console.ReadLine();

//    Console.WriteLine("Lütfen yazarın soyismini giriniz: ");
//    string surname =Console.ReadLine();

//    Author author = new Author(id, name, surname);

//    return author;
//}

//void AddAuthor()
//{
//    Author author = GetAuthorInputs();
//    bool isUnique = AddAuthorValidator(author);

//    if (!isUnique)
//    {
//        Console.WriteLine("Girmiş olduğunuz yazar benzersiz değildir.");
//        return;
//    }
//    authors.Add(author);
//    GetAllAuthors();
//}

//Category GetCategoryInputs()
//{
//    Console.WriteLine("Lütfen kategori id si giriniz.");
//    int id = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen kategori ismini giriniz: ");
//    string name = Console.ReadLine();

//    Category category = new Category(id, name);

//    return category;
//}
//bool AddCategory(Category category)
//{
//    bool isUnique = true;

//    foreach (Category item in categories)
//    {
//        if (item.Id == category.Id || item.Name == category.Name )
//        {
//            isUnique = false;
//            break;
//        }
//    }

//    return isUnique;
//}

//void AddCategory()
//{
//    Category category = GetCategoryInputs();
//    bool isUnique = true;
//    if (!isUnique)
//    {
//        Console.WriteLine("Girmiş olduğunuz kategori benzersiz değildir.");
//        return;
//    }

//    categories.Add(category);

//    GetAllCategories();    
//}



