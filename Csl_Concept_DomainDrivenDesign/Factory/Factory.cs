using Csl_Concept_DomainDrivenDesign.Entites;
using Csl_Concept_DomainDrivenDesign.Valeur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Factory
{
    /// <summary>
    /// La classe BookFactory est un pattern de création d'entités, 
    /// c'est un outil pour créer des instances de Book en respectant les contraintes de création. 


    /// </summary>
    public class Factory
    {

        public static Book Create(string title,string author, string ISBN)
        {
            var bookTitle = new BookTitle(title, ISBN);
            var book = new Book(bookTitle.Title,author);

            return book;
        }
    }
}
