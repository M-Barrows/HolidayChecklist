
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolidayChecklist.Models
{
    public class Season
    {
        [Key]
        public int ParentShowID {get; set;}

        public int SeasonNumber {get; set;}

        public IEnumerable<Episode> Episodes {get; set;}

        public DateTime First_Air_Date {get; set;}
    }
}
            