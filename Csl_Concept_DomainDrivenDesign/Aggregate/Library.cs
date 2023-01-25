using Csl_Concept_DomainDrivenDesign.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Aggregate
{

    /// <summary>
    /// La classe Library est un aggregate qui contient une collection de livres et 
    /// offre des méthodes pour ajouter, supprimer et rechercher des livres. 
    /// </summary>
    public class Library
    {
        public IList<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Guid guid)
        {
            Books.Remove(Books.Single(x => x.Id == guid));

        }


        public Book FindBook(string isbn)
        {
            if(!string.IsNullOrEmpty(isbn))
            {
                return Books.SingleOrDefault(x => x.ISBN.Equals(isbn));
            }
            else
            {
                return null;
            }
          
        }

    }
}
