using Csl_Concept_DomainDrivenDesign.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Service
{
    public class BookService
    {

        private readonly IRepository _repository;

        public BookService(IRepository repository)
        {
            _repository = repository;
        }

        public void CheckOut(string isbn)
        {
            
            _repository.Find(isbn).CheckOut();
        }


        public void CheckIn(string isbn)
        {
            _repository.Find(isbn).CheckIn();
        }


    }
}
