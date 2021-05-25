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
    public class ListOfClientsModel : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ListOfClientsModel(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public IList<ZodiacSign> ZodiacSign { get; set; }
        public IList<Relation> Relation { get; set; }
        public IList<Nationality> Nationality { get; set; }
        

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.ToListAsync();
            ZodiacSign = await _context.ZodiacSigns.ToListAsync();
            Relation = await _context.Relations.ToListAsync();
            Nationality = await _context.Nationalities.ToListAsync();
        }
    }
}