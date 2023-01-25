using Csl_Concept_DomainDrivenDesign.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Specification
{
    public class BookSpecification
    {

        public bool IsSatisfiedBy(Book book)
        {
            return !string.IsNullOrEmpty(book.Title) && !string.IsNullOrEmpty(book.Author)
                && !string.IsNullOrEmpty(book.ISBN);

        }
    }
}
