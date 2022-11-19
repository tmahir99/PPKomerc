using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PPKomerc.Data;
using PPKomerc.Models;

namespace PPKomerc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        

       public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
           var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> AddProuct([FromBody] Products productRequest)
        {
            await _context.Products.AddAsync(productRequest);
            await _context.SaveChangesAsync();
            return Ok(productRequest);

        }
        /*
         // GET: Products
         [HttpGet]
         public async Task<IActionResult> Get()
         {
               return View(await _context.Products.ToListAsync());
         }

         // GET: Products/Details/5
         public async Task<IActionResult> Details(int? id)
         {
             if (id == null || _context.Products == null)
             {
                 return NotFound();
             }

             var products = await _context.Products
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (products == null)
             {
                 return NotFound();
             }

             return View(products);
         }

         // GET: Products/Create
         public IActionResult Create()
         {
             return View();
         }

         // POST: Products/Create
         // To protect from overposting attacks, enable the specific properties you want to bind to.
         // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,Stock")] Products products)
         {
             if (ModelState.IsValid)
             {
                 _context.Add(products);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             return View(products);
         }

         // GET: Products/Edit/5
         public async Task<IActionResult> Edit(int? id)
         {
             if (id == null || _context.Products == null)
             {
                 return NotFound();
             }

             var products = await _context.Products.FindAsync(id);
             if (products == null)
             {
                 return NotFound();
             }
             return View(products);
         }

         // POST: Products/Edit/5
         // To protect from overposting attacks, enable the specific properties you want to bind to.
         // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,Stock")] Products products)
         {
             if (id != products.Id)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(products);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!ProductsExists(products.Id))
                     {
                         return NotFound();
                     }
                     else
                     {
                         throw;
                     }
                 }
                 return RedirectToAction(nameof(Index));
             }
             return View(products);
         }

         // GET: Products/Delete/5
         public async Task<IActionResult> Delete(int? id)
         {
             if (id == null || _context.Products == null)
             {
                 return NotFound();
             }

             var products = await _context.Products
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (products == null)
             {
                 return NotFound();
             }

             return View(products);
         }

         // POST: Products/Delete/5
         [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(int id)
         {
             if (_context.Products == null)
             {
                 return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
             }
             var products = await _context.Products.FindAsync(id);
             if (products != null)
             {
                 _context.Products.Remove(products);
             }

             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }

         private bool ProductsExists(int id)
         {
           return _context.Products.Any(e => e.Id == id);
         }*/
    }
}
