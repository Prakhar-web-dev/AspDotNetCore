using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Store.Models;

namespace Book_Store.Repository
{
    public class BookRepository
    {
        public List<BookModel> getAllBooks()
        {
            return DataSource();
        }
        public BookModel getBook(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(string bookname,string authorName)
        {
            return DataSource().Where(x => x.title.Contains(bookname) && x.author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){id=1,title="Harry",author="Brroks"},
                new BookModel(){id=2,title="Alex",author="Hales"},
                new BookModel(){id=3,title="Josh",author="Inglis"}
            };
        }
    }
}
