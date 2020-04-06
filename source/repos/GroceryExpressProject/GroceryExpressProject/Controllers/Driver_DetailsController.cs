using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroceryExpressProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace GroceryExpressProject.Controllers
{
    public class Driver_DetailsController : Controller
    {
        private readonly GroceryExpressContext _context;

        public Driver_DetailsController(GroceryExpressContext context)
        {
            _context = context;
        }


        [Authorize(Roles = "Admin,DeliveryDriver")]
        // GET: Driver_Details
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drivers.ToListAsync());
        }

        [Authorize(Roles = "Admin,DeliveryDriver")]
        // GET: Driver_Details/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver_Details = await _context.Drivers
                .FirstOrDefaultAsync(m => m.Driver_Id == id);
            if (driver_Details == null)
            {
                return NotFound();
            }

            return View(driver_Details);
        }

        [Authorize(Roles = "Admin,DeliveryDriver")]
        // GET: Driver_Details/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Driver_Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Driver_Id,FullName,License_Number,Phone_Number")] Driver_Details driver_Details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driver_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(driver_Details);
        }

        [Authorize(Roles = "Admin,DeliveryDriver")]
        // GET: Driver_Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver_Details = await _context.Drivers.FindAsync(id);
            if (driver_Details == null)
            {
                return NotFound();
            }
            return View(driver_Details);
        }

        // POST: Driver_Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Driver_Id,FullName,License_Number,Phone_Number")] Driver_Details driver_Details)
        {
            if (id != driver_Details.Driver_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driver_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Driver_DetailsExists(driver_Details.Driver_Id))
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
            return View(driver_Details);
        }

        [Authorize(Roles = "Admin,DeliveryDriver")]
        // GET: Driver_Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driver_Details = await _context.Drivers
                .FirstOrDefaultAsync(m => m.Driver_Id == id);
            if (driver_Details == null)
            {
                return NotFound();
            }

            return View(driver_Details);
        }

        // POST: Driver_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var driver_Details = await _context.Drivers.FindAsync(id);
            _context.Drivers.Remove(driver_Details);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Driver_DetailsExists(int id)
        {
            return _context.Drivers.Any(e => e.Driver_Id == id);
        }
    }
}
