using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin2.Data;
using Microsoft.AspNetCore.Mvc;
using Admin2.Data;
using Admin2.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin2.Controllers
{
    public class SportZoomController : Controller
    {
        private Admin2Context context;
        public SportZoomController(Admin2Context ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View(context.SportRooms);
        }
        
        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SportZoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Address,Hotline")] SportRoom sportRoom)
        {
            if (ModelState.IsValid)
            {
                context.Add(sportRoom);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sportRoom);
        }

        // GET: SubjectController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportRoom = await context.SportRooms.FindAsync(id);
            if (sportRoom == null)
            {
                return NotFound();
            }
            return View(sportRoom);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Address,Hotline")] SportRoom sportRoom)
        {
            if (id != sportRoom.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(sportRoom);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpotZoomExists(sportRoom.ID))
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
            return View(sportRoom);
        }

        // GET: SubjectController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportRoom = await context.SportRooms
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sportRoom == null)
            {
                return NotFound();
            }

            return View(sportRoom);
        }

        // POST: SubjectController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sportZoom = await context.SportRooms.FindAsync(id);
            context.SportRooms.Remove(sportZoom);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpotZoomExists(int id)
        {
            return context.SportRooms.Any(e => e.ID == id);
        }
    }
}
