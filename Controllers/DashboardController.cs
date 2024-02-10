using expensesapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace expensesapp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController (ApplicationDbContext context)

        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            //last seven days
            DateTime StartDate = DateTime.Today.AddDays(-6);
            DateTime EndDate = DateTime.Today;
            List<Transaction> SelectedTransactions = await _context.Transactions
            
            .Include(y => y.Date >= StartDate && y.Date <= EndDate)
            .Where(y => y.Date >= StartDate && y.Date <= EndDate)
            .ToListAsync();
            
            
            return View();
        
        
        }
   
    
    
    
    }
}
