using Csl_Concept_DomainDrivenDesign.Entites;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Repository
{

    /// <summary>
    ///  La classe BookRepository est un repository qui permet de stocker et
    ///  de récupérer des instances de Book à partir d'une source de données. 
    ///  ici pour simplifier les choses on utilise une simple collection List
    /// </summary>
    public class BookRepository : IRepository
    {

        List<Book> ListNBooks = new List<Book>();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Guid id => Guid.NewGuid();

        public string message { get; set; }

        public void Add(Book book)
        {
            ListNBooks.Add(book);
            message = "Add book in Repository";
        }

        public Book Find(string ISBN)
        {
            message = "return a book by  ISBN in Repository";
            return ListNBooks.Find(x => x.ISBN.Equals(ISBN));

        }

            public void Remove(Guid id)
            {
                    var book = ListNBooks.Find(x => x.ISBN.Equals(id));
                    if(book != null)
                    {
                         ListNBooks.Remove(book);
                    }

            message = "remove a book by  Id Guid in Repository";
            log.Info(message);
        }

   
            
        
    }
}
