
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
Book book1 = new Book() { Id = Guid.NewGuid(), ISBN = "12369", Title = "TINTIN", Author = "HERGE", IsCheckedOut = false };
BookFacade bookFacade = new BookFacade();

bookFacade.AddBookInLibrary(book1);
Console.WriteLine( bookFacade.message);




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




