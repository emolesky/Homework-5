using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    // EBook subclass
    public class EBook : Book
    { // class variables
        private int fileSizeMB = 0;

        //gets and sets
        public int FileSizeMB
        {
            get { return fileSizeMB; }
            set { fileSizeMB = value; }
        }
        //constructor calling base
        public EBook(string title, string author, int yearPublished, int fileSizeMB) : base(title, author, yearPublished)
        {
            FileSizeMB = fileSizeMB;
        }

        //ToString
        public override string ToString()
        {
            string msg = "";
            msg += $"{Title} by {Author} {YearPublished} \nFile Size: {FileSizeMB}MB";
            return msg;
        }
    }

    // printed book subclass
    public class PrintedBook : Book
    { // class variables
        private int pageCount = 0;

        // gets and sets
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
        // constructor calling base
        public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
        {
            PageCount = pageCount;
        }

        // ToString
        public override string ToString()
        {
            string msg = "";
            msg += $"{Title} by {Author} {YearPublished} \nNumber of Pages: {PageCount}";
            return msg;
        }

    }
}
