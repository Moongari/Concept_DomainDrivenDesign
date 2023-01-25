using Csl_Concept_DomainDrivenDesign.DomainEvent;
using Csl_Concept_DomainDrivenDesign.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Repository
{
    public interface IDomainEvent
    {
        Book Book { get; set; }
        DateTime CheckOutDate { get; set; }
        BookCheckOutEvent bookCheckOutEvent (Book book, DateTime checkOutDate);
    }
}
