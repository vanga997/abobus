using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Services = new HashSet<Service>();
        }

        [Display(Name = "Код сотрудника")]
        public long WorkerId { get; set; }

        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Возраст")]
        public long Age { get; set; }

        [Display(Name = "Паспорт")]
        public long Passport { get; set; }

        [Display(Name = "Номер телефона")]
        public long Phone { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Код должности")]
        public long PositionId { get; set; }

        [Display(Name = "должность")]
        public virtual Position Position { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
