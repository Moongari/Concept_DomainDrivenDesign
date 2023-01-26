using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_Concept_DomainDrivenDesign.Entites
{

    /// <summary>
    /// La classe Book représente un livre dans la bibliothèque, avec des propriétés comme Title, Author, ISBN, etc. 
    /// Elle possède une méthode CheckOut() pour emprunter un livre. 
    /// Elle possède une méthode CheckIn() pour rendre un livre. 
    /// </summary>
    public class Book
    {

        public Book()
        {

        }
        public Book(string title, string author, Guid id,string isbn)
        {
            Title = title;
            Author = author;
            Id = id;
            ISBN = isbn;
        }

        public Guid Id {get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool IsCheckedOut { get; set; }




        public void CheckOut()
        {
            // Validation and update state 
            IsCheckedOut = true;    
        }


        public void CheckIn()
        {
            // Validation and update state 
            IsCheckedOut = false;

        }



    }
}
