using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class ZodiacSign
    {
        [Display(Name = "Код знака")]
        public long ZodiacId { get; set; }

        [Display(Name = "Знак зодиака")]
        public string ZodiacName { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
