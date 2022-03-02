using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int IdCategory { get; set; }
        public string Editor { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int idCategory, string editor, string iSBN)
        {
            Title = title;
            Author = author;
            IdCategory = idCategory;
            Editor = editor;
            ISBN = iSBN;
        }


    }
}
