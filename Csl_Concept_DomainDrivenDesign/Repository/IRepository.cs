using Csl_Concept_DomainDrivenDesign.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Repository
{
    public interface IRepository : IScopedService
    {
        void Add(Book book);
        void Remove(Guid id);

        Book Find(string ISBN);


    }
}
