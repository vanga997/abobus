using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarriageAgencyWeb.Data;
using MarriageAgencyWeb.Models;

namespace MarriageAgencyWeb.Pages.RequestsAndFilters.Request
{
    public class PersonnelDepartmentModel : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public PersonnelDepartmentModel(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get; set; }
        public IList<Position> Position { get; set; }
        public async Task OnGetAsync()
        {
            Worker = await _context.Workers.ToListAsync();
            Position = await _context.Positions.ToListAsync();
        }
    }
}