using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QL_Sach.Models;
using QL_Sach.ViewModels;

namespace QL_Sach.Controllers
{
    public class BookInforController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public BookInforController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var BookInfors = _appDbContext.BookInfors.Include(p => p.Category).ToList();

            return View(BookInfors);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string Booksearch)
        {
            ViewData["GetBookDetails"] = Booksearch;
            var bookquery = from x in _appDbContext.BookInfors select x;
            if(!string.IsNullOrEmpty(Booksearch))
            {
                bookquery = bookquery.Where(x => x.Name.Contains(Booksearch));
            }
            return View(await bookquery.AsNoTracking().ToListAsync());
        }
        public IActionResult Create()
        {
            BookInforCreateVM productCreateVM = new BookInforCreateVM()
            {
                BookInfor = new BookInfor(),
                CategoriesSelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                })
            };
            return View(productCreateVM);
        }
        [HttpPost]
        public IActionResult Create(BookInforCreateVM bookInforCreateVM)
        {
            _appDbContext.BookInfors.Add(bookInforCreateVM.BookInfor);
            _appDbContext.SaveChanges();
            return View(bookInforCreateVM);
        }

        public IActionResult Details(int id)
        {
            var data = _appDbContext.BookInfors.Find(id);
                
            return View(data);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var bookinfor = _appDbContext.BookInfors.Find(id);
            if (bookinfor == null) return NotFound();

            return View(bookinfor);
        }

        [HttpPost]
        public IActionResult DeleteBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var bookinfor = _appDbContext.BookInfors.Find(id);
            if (bookinfor == null) return NotFound();

            _appDbContext.BookInfors.Remove(bookinfor);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
