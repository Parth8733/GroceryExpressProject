using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroceryExpressProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace GroceryExpressProject.Controllers.ApplicationController
{
    public class Customer_DetailsController : Controller
    {
        private readonly GroceryExpressContext _context;

        public Customer_DetailsController(GroceryExpressContext context)
        {
            _context = context;
        }

        // GET: Customer_Details
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        [Authorize(Roles ="Admin,User")]
        // GET: Customer_Details/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Details = await _context.Customers
                .FirstOrDefaultAsync(m => m.Customer_Id == id);
            if (customer_Details == null)
            {
                return NotFound();
            }

            return View(customer_Details);
        }

        // GET: Customer_Details/Create
        [Authorize(Roles ="Admin,User")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer_Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Customer_Id,FullName,Address,City,Phone_Number")] Customer_Details customer_Details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer_Details);
        }

        [Authorize(Roles = "Admin,User")]
        // GET: Customer_Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Details = await _context.Customers.FindAsync(id);
            if (customer_Details == null)
            {
                return NotFound();
            }
            return View(customer_Details);
        }

        // POST: Customer_Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Customer_Id,FullName,Address,City,Phone_Number")] Customer_Details customer_Details)
        {
            if (id != customer_Details.Customer_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Customer_DetailsExists(customer_Details.Customer_Id))
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
            return View(customer_Details);
        }

        [Authorize(Roles = "Admin,User")]
        // GET: Customer_Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_Details = await _context.Customers
                .FirstOrDefaultAsync(m => m.Customer_Id == id);
            if (customer_Details == null)
            {
                return NotFound();
            }

            return View(customer_Details);
        }

        // POST: Customer_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer_Details = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer_Details);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Customer_DetailsExists(int id)
        {
            return _context.Customers.Any(e => e.Customer_Id == id);
        }
    }
}
