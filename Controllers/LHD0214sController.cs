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
    public class LHD0214sController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LHD0214sController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LHD0214s
        public async Task<IActionResult> Index()
        {
            return View(await _context.LHD0214.ToListAsync());
        }

        // GET: LHD0214s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD0214 = await _context.LHD0214
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD0214 == null)
            {
                return NotFound();
            }

            return View(lHD0214);
        }

        // GET: LHD0214s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LHD0214s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LHDID,LHDName,LHDGender")] LHD0214 lHD0214)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lHD0214);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lHD0214);
        }

        // GET: LHD0214s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD0214 = await _context.LHD0214.FindAsync(id);
            if (lHD0214 == null)
            {
                return NotFound();
            }
            return View(lHD0214);
        }

        // POST: LHD0214s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LHDID,LHDName,LHDGender")] LHD0214 lHD0214)
        {
            if (id != lHD0214.LHDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lHD0214);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LHD0214Exists(lHD0214.LHDID))
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
            return View(lHD0214);
        }

        // GET: LHD0214s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD0214 = await _context.LHD0214
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD0214 == null)
            {
                return NotFound();
            }

            return View(lHD0214);
        }

        // POST: LHD0214s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lHD0214 = await _context.LHD0214.FindAsync(id);
            _context.LHD0214.Remove(lHD0214);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LHD0214Exists(string id)
        {
            return _context.LHD0214.Any(e => e.LHDID == id);
        }
    }
}
