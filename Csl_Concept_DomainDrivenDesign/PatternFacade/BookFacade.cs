using Csl_Concept_DomainDrivenDesign.Aggregate;
using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.Repository;
using Csl_Concept_DomainDrivenDesign.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.PatternFacade
{
    public  class BookFacade : IScopedService
    {


        private Library _library;
        private BookRepository _bookRepository;

        public Guid id { get; }
        public string message { get; set; }
        public BookFacade()
        {

            _library = new Library();
            _bookRepository = new BookRepository();
            id = Guid.NewGuid();

        }




        public Book CreateBookFactory(string title, string author, string isbn)
        {

            message = $"Book Created with Title :{title} , Author : {author} , ISBN : {isbn} ";
            return BookFactory.Create(title,author,isbn);
        }

        public void AddBookInLibrary(Book book) 
        {
          
            _library.AddBook(book);
            message = "new Book added in a Library !";
        }


        public Book FindBook(string isbn)
        {
            return _library.FindBook(isbn);
        }

      
        public void SaveBookInRepository(Book book)
        {
            _bookRepository.Add(book);
            message = "Book added in Repository";
        }

    }
}
