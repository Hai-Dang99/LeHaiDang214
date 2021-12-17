using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeHaiDang214.Models;

namespace LeHaiDang214.Controllers
{
    public class UniversityLHD214sController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UniversityLHD214sController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: UniversityLHD214s
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityLHD214.ToListAsync());
        }

        // GET: UniversityLHD214s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLHD214 = await _context.UniversityLHD214
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityLHD214 == null)
            {
                return NotFound();
            }

            return View(universityLHD214);
        }

        // GET: UniversityLHD214s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityLHD214s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityLHD214 universityLHD214)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityLHD214);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityLHD214);
        }

        // GET: UniversityLHD214s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLHD214 = await _context.UniversityLHD214.FindAsync(id);
            if (universityLHD214 == null)
            {
                return NotFound();
            }
            return View(universityLHD214);
        }

        // POST: UniversityLHD214s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityLHD214 universityLHD214)
        {
            if (id != universityLHD214.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityLHD214);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityLHD214Exists(universityLHD214.UniversityId))
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
            return View(universityLHD214);
        }

        // GET: UniversityLHD214s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLHD214 = await _context.UniversityLHD214
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityLHD214 == null)
            {
                return NotFound();
            }

            return View(universityLHD214);
        }

        // POST: UniversityLHD214s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityLHD214 = await _context.UniversityLHD214.FindAsync(id);
            _context.UniversityLHD214.Remove(universityLHD214);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityLHD214Exists(string id)
        {
            return _context.UniversityLHD214.Any(e => e.UniversityId == id);
        }
    }
}
