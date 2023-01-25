using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Valeur
{

    /// <summary>
    /// La classe BookTitle représente le titre d'un livre. 
    /// Elle est utilisée par la classe Book pour stocker le titre, mais elle n'a pas d'identité propre.
    /// </summary>
    public class BookTitle
    {
        public BookTitle(string title, string iSBN)
        {
            Title = title;
            ISBN = iSBN;
        }

        public string Title { get; set; }
        public string ISBN  { get; set; }



    }
}
