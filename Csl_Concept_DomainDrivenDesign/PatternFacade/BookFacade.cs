using Csl_Concept_DomainDrivenDesign.Aggregate;
using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.Repository;
using Csl_Concept_DomainDrivenDesign.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csl_Concept_DomainDrivenDesign.Specification;
using Csl_Concept_DomainDrivenDesign.Service;
using Csl_Concept_DomainDrivenDesign.DomainEvent;
using System.Security.Policy;

namespace Csl_Concept_DomainDrivenDesign.PatternFacade
{
    public class BookFacade : IScopedService
    {


        private Library _library;
        private BookRepository _bookRepository;
        private BookSpecification _specification;
        private BookService _bookService;
        private BookCheckOutEvent _bookCheckOutEvent;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Guid id { get; }
        public string message { get; set; }
        public BookFacade()
        {

            _library = new Library();
            _bookRepository = new BookRepository();
            _specification = new BookSpecification();
            _bookService = new BookService(_bookRepository);
            _bookCheckOutEvent = new BookCheckOutEvent();
            id = Guid.NewGuid();

        }




        public Book CreateBookFactory(string title, string author, string isbn)
        {

            message = $"Book Created with Title :{title} , Author : {author} , ISBN : {isbn} ";
            log.Info(message);
            return BookFactory.Create(title, author, isbn);
        }

        public void AddBookInLibrary(Book book)
        {

            _library.AddBook(book);
            message = "new Book added in a Library !";
            log.Info(message);
        }


        public Book FindBook(string isbn)
        {
            return _library.FindBook(isbn);
        }


        public void SaveBookInRepository(Book book)
        {
            _bookRepository.Add(book);
            message = "Book added in Repository";
            log.Info(message);
        }


        public Book FindBookByISBN(string isbn)
        {
            return _bookRepository.Find(isbn);
        }



        public bool IsSatisfiedBook(Book book)
        {
            return _specification.IsSatisfiedBy(book);
        }


        public void CheckOutBook(string isbn)
        {
            _bookService.CheckOut(isbn);
            Console.WriteLine("the book contains a isbn " + isbn + "has been checkOut");
        }



        public BookCheckOutEvent CheckoutBookEv(Book book, DateTime time)
            {
            return _bookCheckOutEvent.bookCheckOutEvent(book, time);
            }

    }
    
}
