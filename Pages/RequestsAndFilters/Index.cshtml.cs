using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarriageAgencyWeb.Pages.RequestsAndFilters
{
    public class IndexModel : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public IndexModel(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }
        public List<SelectListItem> Position { get; set; }
        public List<SelectListItem> ZodiacSign { get; set; }
        public List<SelectListItem> Relation { get; set; }
        public List<SelectListItem> Nationality { get; set; }
        public List<SelectListItem> Hobby { get; set; }
        public List<SelectListItem> FamilyStatus { get; set; }


        public IActionResult OnGet()
        {
            Position = _context.Positions.Select(p =>
                new SelectListItem
                {
                    Value = p.PositionId.ToString(),
                    Text = p.PositionName
                }).ToList();

            ZodiacSign = _context.ZodiacSigns.Select(p =>
               new SelectListItem
               {
                   Value = p.ZodiacId.ToString(),
                   Text = p.ZodiacName
               }).ToList();

            Relation = _context.Relations.Select(p =>
               new SelectListItem
               {
                   Value = p.RelationId.ToString(),
                   Text = p.RelationName
               }).ToList();

            Nationality = _context.Nationalities.Select(p =>
               new SelectListItem
               {
                   Value = p.NationalityId.ToString(),
                   Text = p.NationalityName
               }).ToList();

            Hobby = _context.Clients.Select(p =>
              new SelectListItem
              {
                  Value = p.Hobbies.ToString(),
                  Text = p.Hobbies
              }).ToList();

              FamilyStatus = _context.Clients.Select(p =>
              new SelectListItem
              {
                  Value = p.FamilyStatus.ToString(),
                  Text = p.FamilyStatus
              }).ToList();

            return Page();
        }

    }
}