using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Position
    {
        public Position()
        {
            Workers = new HashSet<Worker>();
        }

        [Display(Name = "Код должности")]
        public long PositionId { get; set; }

        [Display(Name = "Должность")]
        public string PositionName { get; set; }

        [Display(Name = "Оклад")]
        public long Salary { get; set; }

        [Display(Name = "Обязанности")]
        public string Responsibility { get; set; }

        [Display(Name = "Требования")]
        public string Requirements { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
