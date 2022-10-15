using Book_Store.Models;
using Book_Store.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult getAllBooks()
        {
            var data = _bookRepository.getAllBooks();
            return View();
        }

        public BookModel getBook(int id)
        {
            return _bookRepository.getBook(id);
        }

        public string searchBook(string bookname,string authorName)
        {
            return $"Bookname is {bookname} && and authorName is {authorName}";
        }
    }
}
