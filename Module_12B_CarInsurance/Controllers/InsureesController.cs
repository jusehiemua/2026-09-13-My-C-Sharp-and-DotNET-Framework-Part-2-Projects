
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module_12B_CarInsurance.Data;
using Module_12B_CarInsurance.Models;

public class InsureesController : Controller
{
    private readonly CarInsuranceContext _context;

    public InsureesController(CarInsuranceContext context)
    {
        _context = context;
    }

    // GET: INSUREES
    public async Task<IActionResult> Index()
    {
        return View(await _context.Insurees.ToListAsync());
    }

    // GET: INSUREES/Admin
    public async Task<IActionResult> Admin()
    {
        var insurees = await _context.Insurees.ToListAsync();
        return View(insurees);
    }

    // GET: INSUREES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: INSUREES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: INSUREES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        //insert this code immediately before if (ModelState.IsValid)
        int age = DateTime.Today.Year - insuree.DateOfBirth.Year;

        if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }

        if (insuree.DateOfBirth.Date >= DateTime.Today)
        {
            ModelState.AddModelError(
                nameof(insuree.DateOfBirth),
                "You are not eligible to request a car insurance quote if you are born today or in the future.");
        }
        else if (age < 16)
        {
            ModelState.AddModelError(
                nameof(insuree.DateOfBirth),
                "You must be at least 16 to request a car insurance quote.");
        }


        if (ModelState.IsValid)
        {
            //decimal insureeQuote = 0;
            //insureeQuote = CalculateInsureeQuote(insureeQuote);
            insuree.Quote = CalculateInsureeQuote(insuree);
            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: INSUREES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: INSUREES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                insuree.Quote = CalculateInsureeQuote(insuree);
                _context.Update(insuree);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id))
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
        return View(insuree);
    }

    // GET: INSUREES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: INSUREES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree != null)
        {
            _context.Insurees.Remove(insuree);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool InsureeExists(int? id)
    {
        return _context.Insurees.Any(e => e.Id == id);
    }

    //private void CalculateInsureeQuote(out decimal insureeQuote)
    private decimal CalculateInsureeQuote(Insuree insuree)
    {
        decimal quote = 50m;

        int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }

        if (age <= 18)
        {
            quote += 100m;
        }
        else if (age <= 25)
        {
            quote += 50m;
        }
        else
        {
            quote += 25m;
        }

        if (insuree.CarYear < 2000)
        {
            quote += 25m;
        }

        if (insuree.CarYear > 2015)
        {
            quote += 25m;
        }

        if (insuree.CarMake == "Porsche")
        {
            quote += 25m;

            if (insuree.CarModel == "911 Carrera")
            {
                quote += 25m;
            }
        }

        quote += 10m * insuree.SpeedingTickets;

        if (insuree.DUI)
        {
            quote *= 1.25m;
        }

        if (insuree.CoverageType == "Full Coverage")
        {
            quote *= 1.50m;
        }

        //insureeQuote = Math.Round(quote, 2);
        return Math.Round(quote, 2);

    }
}
