using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Nationality
    {
        public Nationality()
        {
            Clients = new HashSet<Client>();
        }
        [Display(Name = "Код национальности")]
        public long NationalityId { get; set; }

        [Display(Name = "Национальность")]
        public string NationalityName { get; set; }

        [Display(Name = "Замечания")]
        public string Comments { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
