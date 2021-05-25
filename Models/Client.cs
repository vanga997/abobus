using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarriageAgencyWeb.Models
{
    public partial class Client
    {
        [Display(Name = "Код клиента")]
        public long ClientId { get; set; }
        
        [Display(Name = "ФИО")]
        public string FullName { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Возраст")]
        public long Age { get; set; }

        [Display(Name = "День рождения")]
        public DateTime Birthday { get; set; }
        
        [Display(Name = "Паспорт")]
        public long Passport { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Рост")]
        public long Height { get; set; }

        [Display(Name = "Вес")]
        public long Weight { get; set; }

        [Display(Name = "Семейное положение")]
        public string FamilyStatus { get; set; }

        [Display(Name = "Информация о партнере")]
        public string InfoAboutPartner { get; set; }

        [Display(Name = "Количество детей")]
        public long NumberOfChild { get; set; }

        [Display(Name = "Плохие привычки")]
        public string BadHabbits { get; set; }

        [Display(Name = "Хобби")]
        public string Hobbies { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Код услуги")]
        public long ServiceId { get; set; }

        [Display(Name = "Код национальности")]
        public long NationalityId { get; set; }

        [Display(Name = "Код знака")]
        public long ZodiacId { get; set; }

        [Display(Name = "Код отношения")]
        public long RelationId { get; set; }

        [Display(Name = "Национальность")]
        public virtual Nationality Nationality { get; set; }
        
        [Display(Name = "отношения")]
        public virtual Relation Relation { get; set; }

        [Display(Name = "услуги")]
        public virtual Service Service { get; set; }

    }
}
