using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.AvailabilityService
{

    /// <summary>
    /// est un pattern pour encapsuler les logiques métier complexe qui ne sont pas appropriées 
    /// pour être inclues dans les entités, comme la vérification de la disponibilité d'un livre.
    /// </summary>
    public class BookAvailibilityService
    {

        private readonly IRepository _repository;

        public BookAvailibilityService(IRepository repository)
        {
            this._repository = repository;
        }

        public bool IsBookAvailable(string ISBN)
        {
            var book = _repository.Find(ISBN);
            return !book.IsCheckedOut;
        }


    }
}
