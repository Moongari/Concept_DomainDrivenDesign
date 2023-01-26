using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.DomainEvent
{

    /// <summary>
    /// Domain event : La classe BookCheckedOutEvent est un pattern de notification pour signaler 
    /// les changements d'état dans les entitiés, c'est-à-dire quand un livre est emprunté. 
    /// </summary>
    public class BookCheckOutEvent : IDomainEvent
    {
        public Book Book { get ; set ; }
        public DateTime CheckOutDate { get ; set ; }

        public BookCheckOutEvent bookCheckOutEvent(Book book, DateTime checkOutDate)
        {
            Book = book;
            CheckOutDate = checkOutDate;
            return this;
        }


     
    }
}
