using LearnEntity.Data;
using LearnEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace LearnEntity.Controllers;

public class GradesController : Controller
{
    private readonly SchoolContext _context;

    public GradesController(SchoolContext context)
    {
        _context = context;
    }

    // GET: Grades
    public async Task<IActionResult> Index()
    {
        return View(await _context.Grades.ToListAsync());
    }

    // GET: Grades/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();
        var grade = await _context.Grades.FirstOrDefaultAsync(m => m.GradeId == id);
        if (grade == null) return NotFound();
        return View(grade);
    }

    // GET: Grades/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Grades/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("GradeId,GradeName,Section")] Grade grade)
    {
        if (ModelState.IsValid)
        {
            _context.Add(grade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(grade);
    }

    // GET: Grades/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var grade = await _context.Grades.FindAsync(id);
        if (grade == null) return NotFound();
        return View(grade);
    }

    // POST: Grades/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("GradeId,GradeName,Section")] Grade grade)
    {
        if (id != grade.GradeId) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(grade);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradeExists(grade.GradeId)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(grade);
    }

    // GET: Grades/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var grade = await _context.Grades.FirstOrDefaultAsync(m => m.GradeId == id);
        if (grade == null) return NotFound();
        return View(grade);
    }

    // POST: Grades/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var grade = await _context.Grades.FindAsync(id);
        if (grade != null)
        {
            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    private bool GradeExists(int id)
    {
        return _context.Grades.Any(e => e.GradeId == id);
    }
}