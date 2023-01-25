using Csl_Concept_DomainDrivenDesign.Aggregate;
using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.PatternFacade
{
    public  class BookFacade : IScopedService
    {


        private Library library;
        public Guid id { get; }
        public string message { get; set; }
        public BookFacade()
        {
   
           library = new Library(); 
            id = Guid.NewGuid();

        }

     



        public void AddBookInLibrary(Book book) 
        {
            book.ISBN = "1246993";
            book.Id = id;
        
            library.AddBook(book);
            message = "Book added in a Library Aggregate call";
        }

      

    }
}
