using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Admin2.Data;
using Admin2.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin2.Controllers
{
    public class SubjectController : Controller
    {
        private Admin2Context context;

        public SubjectController(Admin2Context ctx)
        {
            context = ctx;
        }

        // GET: SubjectController
        public ActionResult Index()
        {
            return View(context.Subjects);
        }
        

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Price,Category,ImgSubject,ImgSubjectDetail")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                context.Add(subject);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: SubjectController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Price,Category,ImgSubject,ImgSubjectDetail")] Subject subject)
        {
            if (id != subject.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(subject);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(subject.ID))
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
            return View(subject);
        }

        // GET: SubjectController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await context.Subjects
                .FirstOrDefaultAsync(m => m.ID == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: SubjectController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await context.Subjects.FindAsync(id);
            context.Subjects.Remove(subject);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectExists(int id)
        {
            return context.Subjects.Any(e => e.ID == id);
        }
    }
}
