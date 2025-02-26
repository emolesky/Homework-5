//written by emilynn 
//2/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{ // base class
    public class Book
    { // class variables
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = 0;

        // gets and sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // empty constructor
        public Book() : this("n/a", "n/a", 0)
        {

        }

        // full constructor
        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
        }

        // ToSTring
        public override string ToString()
        {
            string msg = "";
            msg += $"{Title} by {Author} {YearPublished}";
            return msg;
        }

    }

}
