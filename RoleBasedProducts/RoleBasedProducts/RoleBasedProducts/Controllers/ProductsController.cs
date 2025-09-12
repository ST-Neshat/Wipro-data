using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedProducts.Data;
using RoleBasedProducts.Models;

namespace RoleBasedProducts.Controllers
{
    [Authorize(Roles = "Admin,Manager")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IDataProtector _protector;

        public ProductsController(ApplicationDbContext db, IDataProtectionProvider provider)
        {
            _db = db;
            _protector = provider.CreateProtector("RoleBasedProducts.Products.Price");
        }

        // GET: /Product
        public async Task<IActionResult> Index()
        {
            var products = await _db.Products.AsNoTracking().ToListAsync();

            // Unprotect price for display
            foreach (var p in products)
            {
                try
                {
                    var raw = _protector.Unprotect(p.Price);              p.Price = decimal.Parse(raw);
                }
                catch
                {
                    p.Price = 0m;
                }
            }

            return View(products);
        }

        // GET: /Product/Create (Admin only)
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View(new Products());
        }

        // POST: /Product/Create (Admin only)
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var entity = new Products
            {
                Name = model.Name,
                Price = _protector.Protect(model.Price.ToString())
            };

            _db.Products.Add(entity);
            await _db.SaveChangesAsync();

            TempData["Success"] = $"Product \"{model.Name}\" has been successfully created!";
            return RedirectToAction(nameof(Index));
        }

        // GET: /Product/Edit/5 (Admin or Manager)
        public async Task<IActionResult> Edit(int id)
        {
            var products = await _db.Products.FindAsync(id);
            if (products == null) return NotFound();

            // Unprotect to populate UI
            try
            {
                products.Price = decimal.Parse(_protector.Unprotect(products.Price           }
            catch
            {
                products.Price = 0m;
            }

            return View(products);
        }

        // POST: /Product/Edit/5 (Admin or Manager)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Products model)
        {
            if (id != model.Id) return BadRequest();
            if (!ModelState.IsValid) return View(model);

            var entity = await _db.Products.FindAsync(id);
            if (entity == null) return NotFound();

            entity.Name = model.Name;
            entity.Priceotector.Protect(model.Price.ToString());

            await _db.SaveChangesAsync();

            TempData["Success"] = $"Product \"{model.Name}\" has been successfully updated!";
            return RedirectToAction(nameof(Index));
        }

        // GET: /Product/Delete/5 (Admin only)
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var products = await _db.Products.FindAsync(id);
            if (products == null) return NotFound();
            return View(products);
        }

        

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _db.Products
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



        // POST: /Product/Delete/5 (Admin only)
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entity = await _db.Products.FindAsync(id);
            if (entity == null) return NotFound();

            _db.Products.Remove(entity);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Product has been deleted.";
            return RedirectToAction(nameof(Index));
        }
    }
}