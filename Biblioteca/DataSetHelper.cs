using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Biblioteca
{
    class DataSetHelper
    {
        public static readonly string TABLE_BOOKS = "Books";
        public static readonly string COLUMN_BOOK_TITLE = "Title";
        public static readonly string COLUMN_BOOK_AUTHOR = "Author";
        public static readonly string COLUMN_BOOK_ID_CATEGORY = "IdCategory";
        public static readonly string COLUMN_BOOK_EDITOR = "Editor";
        public static readonly string COLUMN_BOOK_ISBN = "ISBN";

        public static readonly string TABLE_CATEGORIES = "Categories";
        public static readonly string COLUMN_CATEGORIES_NAME = "Name";
        public static readonly string COLUMN_CATEGORIES_AGE = "Age";
        public static readonly string COLUMN_CATEGORIES_ID = "ID";

        string fileName = "library.xml";

        public DataSet DataSetLibrary { get; set; }
        public DataTable TableBooks { get; set; }
        public DataTable TableCategories { get; set; }



        private DataSetHelper() {
            DataSetLibrary = new DataSet("Library");

            TableBooks = new DataTable(TABLE_BOOKS);
            TableBooks.Columns.Add(COLUMN_BOOK_TITLE);
            TableBooks.Columns.Add(COLUMN_BOOK_AUTHOR);
            TableBooks.Columns.Add(COLUMN_BOOK_ID_CATEGORY);
            TableBooks.Columns.Add(COLUMN_BOOK_EDITOR); 
            TableBooks.Columns.Add(COLUMN_BOOK_ISBN);

            TableCategories = new DataTable(TABLE_CATEGORIES);
            TableCategories.Columns.Add(COLUMN_CATEGORIES_NAME);
            TableCategories.Columns.Add(COLUMN_CATEGORIES_AGE);
            TableCategories.Columns.Add(COLUMN_CATEGORIES_ID);

            DataSetLibrary.Tables.Add(TableBooks);
            DataSetLibrary.Tables.Add(TableCategories);

            load();
        }

        private static DataSetHelper _instance;

        public static DataSetHelper GetInstance() {
            if (_instance == null) {
                _instance = new DataSetHelper();
            }
            return _instance;
        }

        void load() {
            try
            {
                DataSetLibrary.ReadXml(fileName);
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
        }

        public void save() {
            DataSetLibrary.WriteXml(fileName);
        }

    }
}
