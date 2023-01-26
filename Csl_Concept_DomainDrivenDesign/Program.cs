
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Csl_Concept_DomainDrivenDesign;
using Csl_Concept_DomainDrivenDesign.Repository;
using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.PatternFacade;

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
{
    services.AddScoped<IRepository, BookRepository>();
    services.AddScoped<IScopedService, ScopedService>();
    services.AddScoped<IScopedService, BookFacade>();
    services.AddTransient<ServiceLifetimeReporter>();

}).Build();

ExemplifyServiceLifetime(host.Services, "LifeTime 1");

// Lancement et creation du DDD

string _title = "TINTIN";
string _author = "HERGE";

string isbn = "4569";
string isbn2 = "00236";

Console.WriteLine("-------------  PATTERN FACADE -------------------------");
BookFacade bookFacade = new BookFacade();

var book1 = bookFacade.CreateBookFactory(_title, _author, isbn.ToString());

    if (bookFacade.IsSatisfiedBook(book1))
    {
        Console.WriteLine(bookFacade.message);
        bookFacade.AddBookInLibrary(book1);
        Console.WriteLine(bookFacade.message);

        Console.WriteLine("-------------- SAVE IN REPOSITORY ------------------------");
        bookFacade.SaveBookInRepository(book1);
        Console.WriteLine(bookFacade.message);
    }
Console.WriteLine("\n");


var book2 = bookFacade.CreateBookFactory(_title="TOM & JERRY", _author="WALT DisNey", isbn2.ToString());

if (bookFacade.IsSatisfiedBook(book2))
{
    Console.WriteLine(bookFacade.message);
    bookFacade.AddBookInLibrary(book2);
    Console.WriteLine("----------- FOUND BOOK in LIBRARY ---------------------------");
    Console.WriteLine($"ID : {book2.Id} \n {bookFacade.FindBook(book2.ISBN).Author} \n {book2.Title} is present in library ");

    Console.WriteLine("-------------- SAVE IN REPOSITORY ------------------------");
    bookFacade.SaveBookInRepository(book2);
    Console.WriteLine(bookFacade.message);
    Console.WriteLine("--------------------------------------");
}



    Console.WriteLine("Found book by ISBN in Repository ");
    Console.WriteLine( bookFacade.FindBookByISBN(book1.ISBN).Title);
    Console.WriteLine(bookFacade.FindBookByISBN(book2.ISBN).Title);
    Console.WriteLine("--------------------------------------");

Console.WriteLine(" EMPRUNT D'UN LIVRE  ");
bookFacade.CheckOutBook(book2.ISBN);


var bookEvent = bookFacade.CheckoutBookEv(book2, DateTime.Now);

    if(bookEvent.Book.IsCheckedOut)
        {
            Console.WriteLine($"This book : {bookEvent.Book.Title} has been checkOut ");
        }

Console.WriteLine("--------------------------------------");



await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();

    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServiceLifetimeReporter>();

    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

   
 
    Console.WriteLine();
}




