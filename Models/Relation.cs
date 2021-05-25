using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Relation
    {
        public Relation()
        {
            Clients = new HashSet<Client>();
        }

        [Display(Name = "Код отношения")]
        public long RelationId { get; set; }

        [Display(Name = "Отношение")]
        public string RelationName { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
