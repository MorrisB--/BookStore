using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class StoreController : Controller
    {
        BookStoreEntities storeDB = new BookStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
           /* var genres = new List<Genre>
            {
                new Genre {Name ="Science Fiction" },
                new Genre {Name = "Poetry" },
                new Genre {Name = "Romance" },
    
            };*/
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }

        //GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        //Retrieve genre and associated albums from database//
        {
            var genreModel = storeDB.Genres.Include("Books")
                .Single(g => g.Name == genre);
            return View(genreModel);
        }

        //GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var book = storeDB.Books.Find(id);
            return View(book);
        }

        // GET: /Store/GenreM
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }
    }
}
