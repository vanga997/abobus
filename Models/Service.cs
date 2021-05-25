using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Service
    {
        public Service()
        {
            Clients = new HashSet<Client>();
        }

        [Display(Name = "Код услуги")]
        public long ServiceId { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Стоимость")]
        public long Cost { get; set; }

        [Display(Name = "Код сотрудника")]
        public long WorkerId { get; set; }

        [Display(Name = "Сотрудник")]
        public virtual Worker Worker { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
